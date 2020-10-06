using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myWeb.Models;

namespace myWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(int limit)      //string vardas, string pavarde galima pakeist i objekta me
        {
            // Person me = new Person { Pavarde = pavarde, Vardas = vardas };      //naujas Person objektas

            var sarasas = new List<Person> { 
                new Person() {Vardas ="Tomas", Pavarde="NeTomas" },
                new Person() {Vardas ="Domas", Pavarde="Pavade" },
                new Person() {Vardas ="Jomas", Pavarde="Pavardfenis" },
                new Person() {Vardas ="Gnomas", Pavarde="hfghfghfg" },
                new Person() {Vardas ="Womas", Pavarde="DarKitokas" },
            };

            return View(sarasas.Take(limit).ToList());        //det objekta me geriau, o ne string, nes string galvos, kad ieskai view. Pakoreaguota priimt List'a
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
