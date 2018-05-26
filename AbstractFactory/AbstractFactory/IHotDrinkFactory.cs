using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IHotDrinkFactory
    {
        IHotDrink prepare(int amount);
    }
}
