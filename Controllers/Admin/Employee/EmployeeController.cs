
using System.Threading.Tasks;
using CarBooking.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Admin.Controllers{

    [Route("admin/employee/")]
    [Authorize(Roles="Admin")]
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _ctx;

        public EmployeeController(ApplicationDbContext ctx)
        {
            _ctx = ctx;    
        }

        [HttpGet]
        public  async Task<IActionResult> Index(){
            return View("Views/Admin/Employee/Index.cshtml");
        }

    

    }
}