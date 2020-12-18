using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoLimpioCore.Models;

namespace ProyectoLimpioCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cosas()
        {
            Persona persona = new Persona();
            persona.Nombre = "Papá Noel";
            persona.Edad = 99;
            return View(persona);
        }
    }
}
