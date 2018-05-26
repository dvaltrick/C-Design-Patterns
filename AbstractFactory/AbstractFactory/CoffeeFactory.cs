using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink prepare(int amount)
        {
            Console.WriteLine($"Put coffee in {amount} of water");
            return new Coffee();
        }
    }
}
