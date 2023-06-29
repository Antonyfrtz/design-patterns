using System.Drawing;

namespace DesignPatterns.Models._1
{
    public class Shape : Render
    {
        private int xUpperLeftCorner = 0;
        private int yUpperLeftCorner = 0;
        private int width = 200;
        private int height = 100;
        private Rectangle rect;

        public string draw()
        {
            rect = new Rectangle(xUpperLeftCorner, yUpperLeftCorner, width, height);
            return "Drawing rectangle in shape";
            
        }

        public void paint()
        {
            throw new NotImplementedException();
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }
    }
}
