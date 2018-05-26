using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink prepare(int amount)
        {
            Console.WriteLine($"Put the leafs in {amount} of water");
            return new Tea();
        }
    }
}
