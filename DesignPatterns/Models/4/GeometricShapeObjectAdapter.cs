﻿namespace DesignPatterns.Models._4
{
    public class GeometricShapeObjectAdapter : Shape
    {
        public GeometricShape adaptee;

        public GeometricShapeObjectAdapter(GeometricShape adaptee)
        {
            this.adaptee = adaptee;
        }
        public void draw() { adaptee.drawShape(); }
        public void resize() { Console.WriteLine(description() + "can't be resized. Please create a new one with the required values"); }
    
        public String description()
        {
            if (adaptee.GetType() == typeof(Triangle)) {
                return "Triangle object";
            }
            else if (adaptee.GetType() == typeof(Rhombus))
            {
                return "Rhombus object";
            }
            else {
                return "Unknown object";
            }
        }
        public Boolean isHide()
        {
            return false;
        }
    }
}
