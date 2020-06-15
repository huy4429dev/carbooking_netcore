using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using CarBooking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Admin.Controllers {
    [Route ("admin/ticket")]
    [Authorize (Roles = "Admin")]
    public class TicketController : Controller {

        private ApplicationDbContext _context;

        public TicketController (
            ApplicationDbContext context
        ) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index () {
            var data = from car in _context.Cars
            join ticket in _context.Tickets on car.Id equals ticket.CarId
            join employee in _context.Employees.Where (e => e.Position == Position.MainDriver) on car.Id equals employee.CarId
            join route in _context.Routes on ticket.RouteId equals route.Id
            select new TicketViewModel () {
                Id = route.Id,
                CarCode = car.CarCode,
                RouteName = route.StartPoint + " - " + route.EndPoint,
                Phone = employee.Phone,
                CreatedAt = DateTime.Now
            };
            var result = data.Distinct ().ToList ();
            return View ("Views/Admin/Ticket/Index.cshtml", result);
        }

        [HttpGet ("list/{id}")]
        public async Task<IActionResult> GetAll (int id) {

            var data = await _context.Tickets.Where (item => item.RouteId == id)
                .Select (item => new TicketViewModel {
                    Id = item.Id,
                        Price = item.Price,
                        Endpoint = item.Route.EndPoint,
                        StartPoint = item.Route.StartPoint,
                        TimeEnd = item.Route.TimeEnd,
                        TimeStart = item.Route.TimeStart,
                        StatusTicket = item.StatusTicket,
                        SeatNumberId = item.SeatNumberId,
                        Name = item.Name,
                        BookTickets = item.BookTickets

                }).ToListAsync ();
            ViewBag.route = await _context.Routes.FindAsync (id);
            return View ("Views/Admin/Ticket/TicketList.cshtml", data);
        }

        [HttpGet ("{id}")]
        public async Task<IActionResult> Get (int id) {

            var data = await _context.Tickets.Where (item => item.Id == id)
                .Select (item => new TicketViewModel {
                    Id = item.Id,
                        Price = item.Price,
                        Endpoint = item.Route.EndPoint,
                        StartPoint = item.Route.StartPoint,
                        TimeEnd = item.Route.TimeEnd,
                        TimeStart = item.Route.TimeStart,
                        StatusTicket = item.StatusTicket,
                        SeatNumberId = item.SeatNumberId,
                        Name = item.Name,
                        BookTickets = item.BookTickets,

                }).FirstOrDefaultAsync ();
            var ticket  = await _context.Tickets.FindAsync(id);
            ViewBag.route = await _context.Routes.FindAsync (ticket.RouteId);
            return View ("Views/Admin/Ticket/Detail.cshtml", data);
        }

    }
}