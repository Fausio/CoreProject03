using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProject03.Models;
using CoreProject03.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreProject03.Controllers
{
    public class MusicController : Controller
    {
        private readonly IRepositoryBand _repositoryBand;

        public MusicController(IRepositoryBand repository)
        {
            _repositoryBand= repository;
        }

        public IActionResult Index()
        {
            return View(_repositoryBand.Bands());

        }

        public IActionResult Add()
        {

            return this.View(new Band());
        }

        public IActionResult Details(string id)
        {
            return View(_repositoryBand.Band(id));
        }

        public JsonResult TesteGetDetails()
        {
            return Json(JsonConvert.SerializeObject(new Band { Title = "new new", Origin = "String string", Biography = "bla bla bla", Gender = "R&B" }));
        }

        public IActionResult Edit(string id)
        {
            return View(_repositoryBand.Band(id));
        }

        public IActionResult Delete(string id)
        {
            return View(_repositoryBand.Band(id));
        }

        public IActionResult Create(Band band)
        {
            return RedirectToAction("Index");
        }

        public IActionResult TestePostCreate([FromBody]Band band)
        {
            return RedirectToAction("Index");
        }
    }
}