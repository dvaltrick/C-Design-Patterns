using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class Coffee : IHotDrink
    {
        public void consumes()
        {
            Console.WriteLine("I like coffee");
        }
    }
}
