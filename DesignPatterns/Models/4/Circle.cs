namespace DesignPatterns.Models._4
{
    public class Circle : Shape
    {
        public string draw()
        {
            return "Drawing Circle";
        }

        public string resize()
        {
            return "Resizing Circle";
        }

        public string description()
        {
            return "Circle object";
        }

        public bool isHide()
        {
            return false;
        }
    }
}
