using System;
using System.Collections.Generic;

/* ADAPTER PATTERN
 * 
 * O conceito do adapter diz respeito a converter um objeto com determinadas caracteristicas
 * em outro tipo de objeto, no exemplo temos adaptador que converte uma linha em array de  
 * pontos, nesse acaso tendo apenas as arestas é possível desenhar todo o retangulo
 */ 

namespace AdapterPattern
{
    class Program
    {
        private static readonly List<VectorObject> vectorObjects =
            new List<VectorObject> {
                new Rectangle(1,1,10,10),
                new Rectangle(3,3,6,6)
            };

        public static void DrawPoint(Point p) {
            Console.Write(".");
        }

        static void Main(string[] args)
        {
            Draw();

            Console.ReadLine();
        }

        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    foreach (var point in adapter)
                    {
                        DrawPoint(point);
                    }
                }
            }
        }
    }
}