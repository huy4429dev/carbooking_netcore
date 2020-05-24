
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.Admin.Controllers{

    [Route("admin/contact")]
    public class ContactController : Controller
    {
        public ContactController()
        {
            
        }

        [Authorize(Roles="Admin")]
        public IActionResult Index(){
            return View("Views/Admin/Contact/Index.cshtml");
        }

    }
}