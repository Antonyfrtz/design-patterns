namespace DesignPatterns.Models._4
{
    public class Rectangle : Shape
    {
        public string draw()
        {
            return "Drawing Rectangle";
        }

        public string resize()
        {
            return "Resizing Rectangle";
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
