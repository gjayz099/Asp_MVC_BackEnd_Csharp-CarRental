using CarRental.Data;
using CarRental.Models;
using CarRental.Models.NormalClass;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDataDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDataDbContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {
            List<BlogItem> blogs = new List<BlogItem>()
            {
                new BlogItem {BlogDate = "June 5", BlogPicTittle = "Blog1", BlogName = "Tour Party", BlogPrap = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Soluta rerum architecto fuga suscipit iusto animi!"},
                new BlogItem {BlogDate = "April 9", BlogPicTittle = "Blog2", BlogName = "Event Tour", BlogPrap = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Soluta rerum architecto fuga suscipit iusto animi!"},
                new BlogItem {BlogDate = "October 15", BlogPicTittle = "Blog3", BlogName = "Anniversary", BlogPrap = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Soluta rerum architecto fuga suscipit iusto animi!"},
                new BlogItem {BlogDate = "May 2", BlogPicTittle = "Blog4", BlogName = "Picture Tour", BlogPrap = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Soluta rerum architecto fuga suscipit iusto animi!"},
            };
            ViewBag.List = blogs;
            ViewData["blogs"] = blogs;

            return View(blogs);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Pricing()
        {
            return View(await _context.Car.ToListAsync());
        }
        // GET: Booking/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        //// POST: Booking/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,BookingCarModel,BookingFName,BookingLName,BookingPhoneNum,PickUpDate")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }
        public IActionResult Service()
        {
            List<ServiceItem> services = new List<ServiceItem>()
            {
                new ServiceItem {ServiceIcon = "IconService", ServiceName = "Wedding Ceremony", ServicePar = "Lorem ipsum dolor sit amet consectetur, adipisicing elit consectetur."},
                new ServiceItem {ServiceIcon = "IconService", ServiceName = "Airport Transfer", ServicePar  = "Lorem ipsum dolor sit amet consectetur, adipisicing elit consectetur."},
                new ServiceItem {ServiceIcon = "IconService", ServiceName = "City Transfer", ServicePar  = "Lorem ipsum dolor sit amet consectetur, adipisicing elit consectetur."},
                new ServiceItem {ServiceIcon = "IconService", ServiceName = "Whole City Tour", ServicePar  = "Lorem ipsum dolor sit amet consectetur, adipisicing elit consectetur."},
            };

            ViewBag.List = services;
            ViewData["services"] = services;

            return View(services);
        }

        public IActionResult Team()
        {
            List<TeamItem> teams = new List<TeamItem>()
            {
                new TeamItem {TeamImgName = "TeamPic1", TeamFullName = "GeraldGlen Dangcalan", TeamPosition = "Founder", TeamFbLinks = "#", TeamTtLinks = "#", TeamWaLinks = "#"},
                new TeamItem {TeamImgName = "TeamPic2", TeamFullName = "Christine Leigh Torres", TeamPosition = "Co Founder", TeamFbLinks = "#", TeamTtLinks = "#", TeamWaLinks = "#"},
                new TeamItem {TeamImgName = "TeamPic3", TeamFullName = "Angelline Omandam", TeamPosition = "Designer", TeamFbLinks = "#", TeamTtLinks = "#", TeamWaLinks = "#"},
                new TeamItem {TeamImgName = "TeamPic4", TeamFullName = "Stewart Abad", TeamPosition = "Maintenance", TeamFbLinks = "#", TeamTtLinks = "#", TeamWaLinks = "#"}
            };

            ViewBag.List = teams;
            ViewData["teams"] = teams;

            return View(teams); 
        }
        public IActionResult About()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}