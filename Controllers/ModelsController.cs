using Microsoft.AspNetCore.Mvc;
using TheShop.Models;
using TheShop.ViewModels;
using System.Linq;

namespace TheShop.Controllers
{
    public class ModelsController : Controller
    {
        private readonly IMotocyklRepository _motocyklRepository;

        public ModelsController(IMotocyklRepository motocyklRepository)
        {
            _motocyklRepository = motocyklRepository;

        }

        //public IActionResult Index(id)
        public IActionResult Index(int id)
        {
            ///            var motocykl = _motocyklRepository.PobierzMotocykl(id);

            ///         if (motocykl == null)
            //          return NotFound();
            var motocykle = _motocyklRepository.GetModels(id);

            string modelname="none";

            switch (id)
            {
                case 1:
                    modelname = "BMW";
                    break;
                case 2:
                    modelname = "Ducati";
                    break;
                case 3:
                    modelname = "Kawasaki";
                    break;
                case 4:
                    modelname = "KTM";
                    break;
                case 5:
                    modelname = "Timbersled";
                        break;
                case 6:
                    modelname = "Triumph";
                    break;
                case 7:
                    modelname = "Yeti snowMX";
                    break;
            }


            var modelVM = new ModelVM
            {
                MyModel = modelname,
                Motocykle = motocykle.ToList()
            };

            return View(modelVM);
        
        
        }

        public IActionResult Info(int id)
        {
            var motocykl = _motocyklRepository.PobierzMotocykl(id);

                     if (motocykl == null)
                      return NotFound();

            return View(motocykl);
        }


    }
}