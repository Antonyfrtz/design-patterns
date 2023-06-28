using DesignPatterns.Models._5.Factory;
namespace DesignPatterns.Models._5.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Shape getShape(String shape);
        public abstract Color getColor(String shape, String color);
    }
}
