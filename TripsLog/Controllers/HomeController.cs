using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripsLog.Data;
using TripsLog.Models;

namespace TripsLog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Trip> trips = _db.Trips.ToList();
            return View(trips);
        }           
    }
}