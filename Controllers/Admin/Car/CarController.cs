using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using CarBooking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace CarBooking.Admin.Controllers
{
    [Route("admin/car")]
    public class CarController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ApplicationDbContext _context;

        public CarController(

            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext context
        )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
        }



        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var cars = await _context.Cars.ToListAsync();

        
            return View("Views/Admin/Car/Index.cshtml");
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Detail(int id)
        {
            var cars = await _context.Cars.ToListAsync();

        
            return View("Views/Admin/Car/Detail.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Profile([FromForm] ApplicationUser model)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.Users.FindAsync(Int32.Parse(userId));
            if (ModelState.IsValid)
            {

                user.FullName = model.FullName;
                user.PhoneNumber = model.PhoneNumber;
                if (user.Email != model.Email)
                {
                    user.Email = model.Email;
                }

                if (!string.IsNullOrEmpty(model.Password))
                {
                    var newPassword = _userManager.PasswordHasher.HashPassword(user, model.Password);
                    user.PasswordHash = newPassword;
                }
                var res = await _userManager.UpdateAsync(user);
            }

            return View("Views/Admin/Account/Profile.cshtml", user);
        }


        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UpdateAvatar()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.Users.FindAsync(Int32.Parse(userId));

            try
            {
                
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "uploads");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var now = DateTime.Now.Ticks.ToString();
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var typeFile = fileName.Substring(fileName.LastIndexOf("."));
                    fileName =  fileName.Substring(0,fileName.Length - typeFile.Length) + now + typeFile;
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    dbPath = dbPath.Substring(7);
                     
                    user.Avatar = dbPath;
                    await _userManager.UpdateAsync(user);

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server errors {e}");
            }
        }

    }
}