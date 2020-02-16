using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invertir_Numero_de_Dos_Cifras___Ejercicio_1.Funciones;
using Invertir_Numero_de_Dos_Cifras___Ejercicio_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Invertir_Numero_de_Dos_Cifras___Ejercicio_1.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(NumeroIngresado numeroIngresado)
        {
            if (ModelState.IsValid)
            {
                ViewData["numInver"] = Funtions.InvertirCifras(numeroIngresado.Numero);
            } 
            return View();
        }
    }
}