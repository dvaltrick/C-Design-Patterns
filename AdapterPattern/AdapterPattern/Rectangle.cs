using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Rectangle : VectorObject
    {

        public Rectangle(int x, int y, int width, int heigth) {
            Add(new Line(new Point(x,y), new Point(x+width,y)));
            Add(new Line(new Point(x+width,y), new Point(x+width,y+heigth)));
            Add(new Line(new Point(x,y), new Point(x,y+heigth)));
            Add(new Line(new Point(x,y+heigth), new Point(x+width,y+heigth)));
        }
    }
}
