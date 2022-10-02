using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripsLog.Data;
using TripsLog.Models;

namespace TripsLog.Controllers
{
    public class TripController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TripController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: TripController
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Trip obj)
        {
            TempData["Destination"] = obj.Destination;
            TempData["StartDate"] = obj.StartDate;
            TempData["EndDate"] = obj.EndDate;

            if (obj.Accommodation != null)
            {
                TempData["Accommodation"] = obj.Accommodation;
                return RedirectToAction("Page2");
            }
            else
            {
                return RedirectToAction("Page3");
            }

        }

        // GET: TripController/Details/5
        public IActionResult Page2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Page2(Trip obj)
        {
            TempData["AccommodationEmail"] = obj.AccommodationEmail;
            TempData["AccommodationPhone"] = obj.AccommodationPhone;
            return RedirectToAction("Page3");
        }

        // GET: TripController/Create
        public IActionResult Page3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Trip obj)
        {
            Trip trip = new Trip();

            trip.Destination = TempData["Destination"].ToString();
            trip.Accommodation = TempData["Accommodation"]?.ToString();
            trip.StartDate = Convert.ToDateTime(TempData["StartDate"].ToString());
            trip.EndDate = Convert.ToDateTime(TempData["EndDate"].ToString());
            trip.AccommodationEmail = TempData["AccommodationEmail"].ToString();
            trip.AccommodationPhone = TempData["AccommodationPhone"].ToString();
            trip.ThingToDo1 = obj.ThingToDo1;
            trip.ThingToDo2 = obj.ThingToDo2;
            trip.ThingToDo3 = obj.ThingToDo3;
            _db.Trips.Add(trip);
            _db.SaveChanges();
            TempData.Clear();
            TempData["success"] = "Trip has been added";

            return RedirectToAction("Index", "Home");
        }
    }
}
