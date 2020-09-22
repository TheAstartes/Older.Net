using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TheShop.Models;
using TheShop.ViewModels;

namespace TheShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMotocyklRepository _motocyklRepository;

        public HomeController(IMotocyklRepository motocyklRepository)
        {
            _motocyklRepository = motocyklRepository;

        }
        public IActionResult Index()
        {

            var motocykle = _motocyklRepository.PobierzWszystkieMotocykle().OrderBy(s => s.Marka);

            var homeVM = new HomeVM()
            {
                Tytul = "Przegląd Motocykli",
                Motocykle = motocykle.ToList()
            };
           
            return View(homeVM);
        }
    }
}