using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class Tea : IHotDrink
    {
        public void consumes()
        {
            Console.WriteLine("I like tea");
        }
    }
}
