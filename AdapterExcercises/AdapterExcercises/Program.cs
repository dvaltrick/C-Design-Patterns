﻿using System;

namespace AdapterExcercises
{
    public class Square
    {
        public int Side;
    }

    public interface IRectangle
    {
        int Width { get; }
        int Height { get; }
    }

    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }

    public class SquareToRectangleAdapter : IRectangle
    {
        
        public SquareToRectangleAdapter(Square square)
        {
            Width = square.Side;
            Height = square.Side;
        }

        public int Width { get; set; }

        public int Height { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}