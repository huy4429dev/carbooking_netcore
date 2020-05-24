
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.Admin.Controllers{

    [Route("admin/dashboard")]
    public class DashboardController : Controller
    {
        public DashboardController()
        {
            
        }

        [Authorize(Roles="Admin")]
        public IActionResult index(){
            return View("Views/Admin/Dashboard/Index.cshtml");
        }

    }
}