using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myPetShop.Models;

namespace myPetShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPetForm() 
        {
            ViewData["Message"] = "Fill this form in";
            return View();
        }
        [HttpPost]
        public IActionResult AddPetToDB(string name, string owner, string sex, int type)
        {
            ModelFacade facade = new ModelFacade();
            bool res = facade.CheckAdd(name, owner, sex, type);
            if (res)
            {
                ViewData["Message"] = "OK! All your data were saved!";
            }
            else
            {
                ViewData["Message"] = "Something bad happended";
            }
            return View();
        }
        [HttpGet]
        public IActionResult ListPets()
        {
            ModelFacade facade = new ModelFacade();
            List<string>[] list = facade.SelectAllPets();
            ViewData["Message"] = "Here you go, your list of pets";

            return View(list);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
