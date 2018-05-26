using Autofac;
using System;

/* BRIDGE PATTERN
 * 
 * Trata-se de uma forma de solucionar o problema de duplicação de heranças
 * 
 */ 

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implementação normal 
            IRenderer r = new VectorRenderer();
            Circle c = new Circle(r, 5);
            
            c.Draw();
            c.Resize(2);
            c.Draw();
             
             */

            //Implementação com injeção de dependência
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>().SingleInstance();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

            using (var c = cb.Build()) {
                var circle = c.Resolve<Circle>(new PositionalParameter(0,5.0f));
                circle.Draw();
                circle.Resize(2);
                circle.Draw();
            }




            Console.ReadLine();
        }
    }
}