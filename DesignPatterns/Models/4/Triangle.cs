namespace DesignPatterns.Models._4
{
    public class Triangle : GeometricShape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        public Triangle() : this(1.0d, 1.0d, 1.0d)
        {
            
        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public double area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void drawShape()
        {
            Console.WriteLine("Drawing Triangle with area: " + area() + " and perimeter: " + perimeter());
        }

        public double perimeter()
        {
            return a + b + c;
        }
    }
}
