using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class PointFactory
    {
        //Factory method
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
}
