using System.Text;

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

        public string draw()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (shapes.Count == 0)
            {
                stringBuilder.AppendLine("Nothing to draw!");
            }
            else
            {
                shapes.ForEach(x => stringBuilder.AppendLine( x.draw()));
            }
            return stringBuilder.ToString();
        }

        public string resize()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (shapes.Count == 0)
            {
                stringBuilder.AppendLine("Nothing to resize!");
            }
            else
            {
                shapes.ForEach(x => stringBuilder.AppendLine( x.resize()));
            }
            return stringBuilder.ToString();
        }

    }
}
