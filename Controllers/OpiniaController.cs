using Microsoft.AspNetCore.Mvc;
using TheShop.Models;

namespace TheShop.Controllers
{
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepository _opiniaRepository;

        public OpiniaController(IOpiniaRepository opiniaRepository)
        {
            _opiniaRepository = opiniaRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            if (ModelState.IsValid)
            {
                _opiniaRepository.DodajOpinie(opinia);

                return RedirectToAction("Sent");
            }
            return View(opinia);
        }
        public IActionResult Sent()
        {
            return View();
        }
    }
}