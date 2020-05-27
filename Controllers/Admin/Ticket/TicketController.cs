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
    [Route("admin/ticket")]
    [Authorize(Roles = "Admin")]
    public class  TicketController : Controller
    {
       
        private ApplicationDbContext _context;

        public TicketController(
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
            return View("Views/Admin/Ticket/Index.cshtml", data);
        }


    }
}