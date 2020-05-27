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
    [Route("admin/car")]
    [Authorize(Roles = "Admin")]
    public class CarController : Controller
    {
       
        private ApplicationDbContext _context;

        public CarController(
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
            return View("Views/Admin/Car/Index.cshtml", data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            var car =  await _context.Cars
                                     .Where(item => item.Id == id)
                                     .Include(item => item.CarImages)   
                                     .Include(item => item.Employees)
                                     .FirstAsync();        

            ViewBag.MainDriver = await _context.Employees
                                     .Where(item => item.Position == Position.MainDriver)
                                     .ToListAsync();

            ViewBag.SubDriver  = await _context.Employees
                                     .Where(item => item.Position == Position.SubDriver)
                                     .ToListAsync();


            return View("Views/Admin/Car/Detail.cshtml", car);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View("Views/Admin/Car/Create.cshtml");
        }

        [HttpPost("create")]
        public  async Task<IActionResult> Create([FromForm] Car model)
        {
            if(ModelState.IsValid){
                

                // string JsonString = Request.Form["CarImages"];
                // var CarImages  = JsonConvert.DeserializeObject<List<CarImage>>(model.CarImages);
                

               
                // JArray  o = JArray.Parse(JsonString);
                // foreach ( var item in o)
                // {
                //      dynamic data = JObject.Parse(item.ToString());
                     
                //      return Ok(data.Url);

                //     //  CarImages.Add(new CarImage(){
                //     //      Url = data.Url,
                //     //      Size = data.Size,
                //     //      Created_At = DateTime.Now
                //     //  });
                // }



                var Car = new Car {
                    CarCode        = model.CarCode,
                    Description    = model.Description,
                    Thumbnail      = model.Thumbnail,
                    SeatNumber     = model.SeatNumber,
                    SeatNumberRest = model.SeatNumber,
                    StatusCar      = StatusCar.Maintenance,
                    Created_At     = DateTime.Now,
                    CarImages      = model.CarImages

                };

                await _context.Cars.AddAsync(Car);
                await _context.SaveChangesAsync();
            
                ViewBag.message = "Thêm xe thành công"; 
                ModelState.Clear();
            } 
            return View("Views/Admin/Car/Create.cshtml");
        }


        [HttpPost("upload/thumbnail"), DisableRequestSizeLimit]
        public IActionResult UploadThumbnail()
        {

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
                    var thumbnail = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    thumbnail = thumbnail.Substring(7);
                     

                    return Ok(new { thumbnail , fileSize = file.Length  });
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