namespace DesignPatterns.Models._1
{
    public class GeometricShape : Coordinates
    {
        private Shape _shape;
        public GeometricShape(Shape shape) { _shape = shape; }

        public int getXLowerRightCorner() { return _shape.getWidth(); }
        public int getYLowerRightCorner() { return _shape.getHeight(); }
    }
}
