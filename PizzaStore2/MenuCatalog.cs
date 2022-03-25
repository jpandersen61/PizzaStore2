using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    class MenuCatalog
    {
        Dictionary<int, Pizza> pizzas;

        public MenuCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
        }

        public void CreatePizza(Pizza pizza)
        {
            pizzas.Add(pizza.Number, pizza);
        }

        public Pizza ReadPizza(int number)
        {
            return pizzas[number];
        }

        public void UpdatePizza(Pizza pizza)
        {
            
        }

        public void DeletePizza(int number)
        {
            
        }
    }
}
