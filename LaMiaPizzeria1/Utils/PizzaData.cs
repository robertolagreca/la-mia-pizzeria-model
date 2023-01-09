﻿using LaMiaPizzeriaModel.Models;

namespace LaMiaPizzeriaModel.Utils
{
    //Classe statica che rappresenta la lista di pizze
    //La lista di pizze sono oggetti di tipo pizza della classe Pizza
    public static class PizzaData
    {
        private static List<Pizza> pizzas;

        public static List<Pizza> GetPizzas()
        {
            if (pizzas != null)
            {
                return pizzas;
            }

            pizzas = new List<Pizza>();

            Pizza pizza1 = new Pizza(0, "~/img/fernando-andrade-_P76trHTWDE-unsplash.jpg", "Margherita", "Sugo, mozzarella", 4.99f);
            Pizza pizza2 = new Pizza(0, "~/img/fernando-andrade-_P76trHTWDE-unsplash.jpg", "Wusterl", "Sugo, mozzarella, wusterl", 5.99f);
            Pizza pizza3 = new Pizza(0, "~/img/fernando-andrade-_P76trHTWDE-unsplash.jpg", "Americana", "Sugo, mozzarella, wusterl, patatine", 6.99f);

            pizzas.Add(pizza1);
            pizzas.Add(pizza2);
            pizzas.Add(pizza3);

            return pizzas;

        }
    }
}