using System.Drawing;

namespace DesignPatterns.Models._5.AbstractFactory
{
    public class ColoredSquare : Color
    {
        private String _color;


        public ColoredSquare(String color)
        {
            _color = color;
        }

        public string draw(){ return _color + " Rectangle"; }
    }
}
