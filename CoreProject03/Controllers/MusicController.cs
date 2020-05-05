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
        public List<Band> listMusic = new List<Band>()
                        {
                            new Band{Title= "Dope Music volume 1", Origin="Linha de cintra",Biography="de africa para europa",Gender="Rap"},
                            new Band{Title= "Nkatanga", Origin="Moçambique",Biography="string string sting ",Gender="Jazz"},
                            new Band{Title= "The moon", Origin="String string",Biography="bla bla bla",Gender="R&B"}
      } ;

        public IActionResult Index()
        {
            return View(listMusic);

        }

        public IActionResult Add()
        {

            return this.View(new Band());
        }

        public IActionResult Details(string id)
        {
            return View(listMusic.Where(x => x.Title == id).FirstOrDefault());
        }

        public IActionResult TesteGetDetails( )
        {
            return View(new Band { Title = "new new", Origin = "String string", Biography = "bla bla bla", Gender = "R&B" });
        }

        public IActionResult Edit(string id)
        {
           return View(listMusic.Where(x=> x.Title ==id).FirstOrDefault());
        }

        public IActionResult Delete(string id)
        {
            return View(listMusic.Where(x => x.Title == id).FirstOrDefault());
        }

        public IActionResult Create(Band band)
        {
            return RedirectToAction("Index");
        }
    }
}