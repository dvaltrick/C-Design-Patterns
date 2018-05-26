using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing pixels for circles with radius: {radius}");
        }
    }
}
