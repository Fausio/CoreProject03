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
            return View(new List<Music>()
                        {
                            new Music{Title= "4 ou 5",Author="Força Suprema ft Prodigio"},
                            new Music{Title= "Hello",Author="Beyonce"},
                            new Music{Title= "Patrão",Author="MC - Roger"}
                        }
           );
        }
    }
}