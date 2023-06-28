using DesignPatterns.Models._5.Factory;

namespace DesignPatterns.Models._5.AbstractFactory
{
    public class ColorShapeFactory : AbstractFactory
    {      
        
        public override Color getColor(string shape, string color)
        {
            if (shape.Equals("RECTANGLE"))
            {
                return new ColoredRectangle(color);
            }
            else if (shape.Equals("SQUARE"))
            {
                return new ColoredSquare(color);
            }
            else
            {
                return null;
            }
        }

        public override Shape getShape(string shape)
        {
            return null;
        }
    }
}
