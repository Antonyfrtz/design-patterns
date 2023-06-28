﻿namespace DesignPatterns.Models._4
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public void resize()
        {
            Console.WriteLine("Resizing Rectangle");
        }

        public string description()
        {
            return "Rectangle object";
        }

        public bool isHide()
        {
            return false;
        }
    }
}
