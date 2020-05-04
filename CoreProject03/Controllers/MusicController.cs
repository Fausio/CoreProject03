using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProject03.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject03.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Band>()
                        {
                            new Band{Title= "Dope Music volume 1", Origin="Linha de cintra",Biography="de africa para europa",Gender="Rap"},
                            new Band{Title= "Nkatanga", Origin="Moçambique",Biography="string string sting ",Gender="Jazz"},
                            new Band{Title= "The moon", Origin="String string",Biography="bla bla bla",Gender="R&B"},
                        }
           );
        }

        public IActionResult Add()
        {

            return this.View(new Band());
        }

        public IActionResult Details(Band band)
        {
            return View(band);
        }

        public IActionResult Edit(Band band)
        {
            return View(band);
        }

        public IActionResult Delete(Band band)
        {
            return View(band);
        }
    }
}