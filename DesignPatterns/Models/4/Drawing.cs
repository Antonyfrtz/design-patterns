namespace DesignPatterns.Models._4
{
    public class Drawing
    {
        List<Shape> shapes = new List<Shape>();

        public Drawing() { }

        public void addShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public List<Shape> getShapes()
        {
            return new List<Shape>(shapes);
        }

        public void draw()
        {
            if (shapes.Count == 0)
            {
                Console.WriteLine("Nothing to draw!");
            }
            else
            {
                shapes.ForEach(x => x.draw());
            }
        }

        public void resize()
        {
            if (shapes.Count == 0)
            {
                Console.WriteLine("Nothing to resize!");
            }
            else
            {
                shapes.ForEach(x => x.resize());
            }
        }

    }
}
