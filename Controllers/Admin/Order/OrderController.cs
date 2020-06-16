using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CarBooking.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Net.Http.Headers;
using CarBooking.Models;
using System.Security.Claims;
using CarBooking.ViewModels;

namespace CarBooking.Admin.Controllers
{
    [Route("admin/order")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;

        public OrderController(
            ApplicationDbContext context
        )
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            return View("/Views/Admin/Order/Index.cshtml");
        }
    }
}