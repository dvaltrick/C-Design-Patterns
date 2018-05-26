using System;

/* ABSTRACT FACTORY
 * 
 * É uma forma de abstrair as factories das classes abstraidas, dessa forma quando temos 
 * várias classe que implementam a mesma interface, cada uma deve ter sua factory e podemos
 * abstrair uma factory generica que irá criar e utilizar as demais conforme a necessidade
 */ 

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
            drink.consumes();

            Console.ReadLine();
        }
    }
}