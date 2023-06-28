namespace DesignPatterns.Models._4
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
        }

        public void resize()
        {
            Console.WriteLine("Resizing Circle");
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
