using DeckOfCardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckOfCardsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DeckDAL DAL = new DeckDAL();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Models.Deck d = DAL.ShuffleCards();
            Player p = DAL.DrawACard(d.deck_id);

            return View(p);
        }
        public IActionResult DrawAgain()
        {
            Models.Deck d = DAL.ShuffleCards();
            Player p = DAL.DrawACard(d.deck_id);

            return View(p);
        }
        public IActionResult Privacy()
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