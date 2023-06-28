using DesignPatterns.Models._5.Factory;

namespace DesignPatterns.Models._5.AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override Shape getShape(String shapeType)
        {
            return shapeType switch
            {
                "CIRCLE" => new Circle(),
                "RECTANGLE" => new Rectangle(),
                "SQUARE" => new Square(),
                _ => throw new NotSupportedException(),
            };
        }
        public override Color getColor(String shape, String color) { return null; }
    }
}
