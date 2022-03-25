using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    class Store
    {
        public void Start()
        {
            Test();
        }

        public void Test()
        {
            MenuCatalog menuCat = new MenuCatalog();

            Pizza p1 = new Pizza(1, "Calzone", 65);
            Pizza p2 = new Pizza(2, "4 Årstider", 50);

            menuCat.CreatePizza(p1);
            menuCat.CreatePizza(p2);

            Console.WriteLine("Pizza created:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);


            Console.WriteLine("Reading Pizzas:");
            Console.WriteLine(menuCat.ReadPizza(1));


        }
    }
}
