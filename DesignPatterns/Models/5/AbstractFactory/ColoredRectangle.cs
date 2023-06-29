namespace DesignPatterns.Models._5.AbstractFactory
{
    public class ColoredRectangle : Color
    {
        private String _color;
        public ColoredRectangle(String color) { _color = color; }
        public string draw() { return _color + " Rectangle"; }
    }
}
