using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CarBooking.Admin.Controllers
{
    [Route("admin/route")]
    [Authorize(Roles = "Admin")]
    public class  RouteController : Controller
    {
       
        private ApplicationDbContext _context;

        public RouteController(
            ApplicationDbContext context
        )
        {
            _context = context;
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _context.Cars
                                     .Include(item => item.Employees)
                                     .ToListAsync();
            return View("Views/Admin/Route/Index.cshtml", data);
        }


    }
}