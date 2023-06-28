namespace DesignPatterns.Models._5.AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(Boolean colorFactory)
        {
            if (colorFactory)
            {
                return new ColorShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
