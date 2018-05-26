using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Shape
    {
        protected IRenderer renderer;

        protected Shape(IRenderer renderer) {
            this.renderer = renderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}
