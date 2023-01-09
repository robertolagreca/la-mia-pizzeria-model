﻿using LaMiaPizzeriaModel.Models;
using LaMiaPizzeriaModel.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> listPizzas = PizzaData.GetPizzas();
            return View("Index" , listPizzas);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> listPizzas = PizzaData.GetPizzas();

            foreach (Pizza pizza in listPizzas)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("La pizza non esiste!");
        }

    }
}
