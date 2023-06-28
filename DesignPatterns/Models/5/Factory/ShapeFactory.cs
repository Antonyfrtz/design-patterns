namespace DesignPatterns.Models._5.Factory
{
    public class ShapeFactory
    {
        public Shape getShape(String shapeType)
        {
            return shapeType switch
            {
                "CIRCLE" => new Circle(),
                "RECTANGLE" => new Rectangle(),
                "SQUARE" => new Square(),
                _ => throw new NotSupportedException(),
            };
        }
    }
}
