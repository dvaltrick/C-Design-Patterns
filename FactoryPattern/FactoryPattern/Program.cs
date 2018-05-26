using System;

/* FACTORY PATTERN
 * 
 * Factory Pattern permite evoluir a forma de utilização dos contrutores, possibilitando por
 * exemplo utilizar mais de uma assinatura de construção com os mesmo parâmetros com finalidade 
 * diferentes
 * 
 * No exemplo vemos que o objeto Point pode ser criado de duas formas, a primeira respeitando o
 * construtor original e a segunda realizando operações que resultarão em uma chamado do contrutor
 * com valores diferentes dos recebidos inicialmente
 * 
 */ 

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI);
            Console.WriteLine(point);
            Console.ReadLine();
        }
    }
}