using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing raster renderer circle with radius: {radius}");
        }
    }
}
