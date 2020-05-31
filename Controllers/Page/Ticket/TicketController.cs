using System.Threading.Tasks;
using CarBooking.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using CarBooking.ViewModels;
using CarBooking.Models;

namespace CarBooking.Page.Controllers
{
    public class TicketController : Controller
    {
        private ApplicationDbContext _context;

        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            var data = from route in _context.Routes.Where(r => r.TimeStart > DateTime.Now)
                       join ticket in _context.Tickets.Where(t => (int)t.StatusTicket != 1)
                       on route.Id equals ticket.RouteId
                       join car in _context.Cars
                       on ticket.CarId equals car.Id
                       join employee in _context.Employees
                       on car.Id equals employee.CarId
                       select new TicketViewModel()
                       {
                           Id         = route.Id,
                           StartPoint = route.StartPoint,
                           Endpoint   = route.EndPoint,
                           TimeStart  = route.TimeStart,
                           TimeEnd    = route.TimeEnd,
                           Price      = ticket.Price,
                           Tickets    = route.Tickets,
                           Car        = new Car()
                           {
                               SeatNumber = car.SeatNumber,
                               CarImages = car.CarImages,
                               Thumbnail = car.Thumbnail,
                               Employees = car.Employees
                           }

                       };
              var result = await data.ToListAsync();
            return View(result);
        }
    }
}