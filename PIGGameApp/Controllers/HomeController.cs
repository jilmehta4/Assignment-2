using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PIGGameApp.Models;
using System.Data;
using System.Data.SqlTypes;
//using PIGGameApp.Models;
using System.Diagnostics;
//using System.Random;

namespace PIGGameApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            var session = new GameSession(HttpContext.Session);
            var game = new Game()
            {
                Player1Total = session.GetP1T(),
                Player2Total = session.GetP2T(),
                Total = session.GetT()   
            };
            return View(game);


        }

        public IActionResult NewGame()
        {
            var session = new GameSession(HttpContext.Session);
            session.SetP1T(0);
            session.SetP2T(0);
            session.SetT(0);

            return RedirectToAction("Index");
        }

        public IActionResult Hold()
        {
            var session = new GameSession(HttpContext.Session);
            var Player1turn = new bool();
            if (!Player1turn)
            {
                session.SetP2T(session.GetT());
            }
            session.SetP1T(session.GetT());

            session.SetT(0);

            return RedirectToAction("Index");
        }
            
        public IActionResult Roll()
        {
            var session = new GameSession(HttpContext.Session);
            Random rand = new Random();
            int roll = rand.Next(1, 7);

            TempData["Roll"] = roll;

            int total = session.GetT();
            total += roll;
            session.SetT(total);

           
            
            
            session.GetP2T();

            return RedirectToAction("Index");
        }
        

    }
}