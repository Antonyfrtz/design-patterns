using DesignPatterns.Models._1;
using DesignPatterns.Models._2;
using DesignPatterns.Models._3;
using DesignPatterns.Models._3.Components;
using DesignPatterns.Models._4;
using DesignPatterns.Models._5.AbstractFactory;
using DesignPatterns.Models._5.Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Controlers
{
    public class MainController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        public string main1()
        {
            StringBuilder sb = new StringBuilder();
            Models._1.Shape shape = new Models._1.Shape();
            sb.AppendLine(shape.draw());
            Models._1.GeometricShape geometricShape = new Models._1.GeometricShape(shape);
            sb.Append("\n Lower write corner of X is: ").Append(geometricShape.getXLowerRightCorner());
            sb.Append("\n Lower write corner of Y is: ").Append(geometricShape.getYLowerRightCorner());
            return sb.ToString();
        }

        public string main2()
        {
            Door door = new Door();
            PasswordProtector protector = new PasswordProtector();
            ProtectedDoor door2 = new ProtectedDoor(protector);
            open(door2);
            open(door);

            static void open(Door d)
            {
                d.unlockDoor();
            }
            return "Protected Door unlocked as regular door!";
        }

        public string main3()
        {
            StringBuilder sb = new StringBuilder();
            // Premium
            Dictionary<CoffeeSelection, CoffeeBean> beans = new Dictionary<CoffeeSelection, CoffeeBean>();
            PremiumCoffeeMachine premiumCoffeeMachine = new PremiumCoffeeMachine(beans);
            // Basic
            Dictionary<CoffeeSelection, GroundCoffee> groundCoffee = new Dictionary<CoffeeSelection, GroundCoffee>();
            BasicCoffeeMachine basicCoffeeMachine = new BasicCoffeeMachine(groundCoffee);

            // Brew premium and basic coffees - Premium machine implementation of both
            premiumCoffeeMachine.brewEspresso();
            sb.AppendLine("Brewed Espresso");
            premiumCoffeeMachine.brewFilterCoffee();
            sb.AppendLine("Brewed Filtered Coffee with Espresso machine");
            // Brew basic coffees - Basic implementation
            basicCoffeeMachine.brewFilterCoffee();
            sb.AppendLine("Brewed Filtered Coffee with Basic coffee machine");

            return sb.ToString();
        }

        public string main4()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Creating drawing of shapes...");
            Drawing drawing = new Drawing();
            drawing.addShape(new Models._4.Rectangle());
            drawing.addShape(new Models._4.Circle());
            drawing.addShape(new GeometricShapeObjectAdapter(new Triangle()));
            drawing.addShape(new GeometricShapeObjectAdapter(new Rhombus()));
            sb.AppendLine("Drawing...");
            sb.AppendLine(drawing.draw());
            sb.AppendLine("Resizing...");
            sb.AppendLine(drawing.resize());
            return sb.ToString();
        }

        public string main5()
        {
            StringBuilder sb = new StringBuilder();
            Models._5.Factory.ShapeFactory shapeFactory = new Models._5.Factory.ShapeFactory();
            //get an object of Circle and call its draw method.
            Models._5.Factory.Shape shape1 = shapeFactory.getShape("CIRCLE");
            //call draw method of Circle
            sb.AppendLine(shape1.draw());
            //get an object of Rectangle and call its draw method.
            Models._5.Factory.Shape shape2 = shapeFactory.getShape("RECTANGLE");
            //call draw method of Rectangle
            sb.AppendLine(shape2.draw());
            //get an object of Square and call its draw method.
            Models._5.Factory.Shape shape3 = shapeFactory.getShape("SQUARE");
            //call draw method of square
            sb.AppendLine(shape3.draw());
            return sb.ToString();
        }

        public string main6()
        {
            StringBuilder sb = new StringBuilder();
            //get rounded shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory(true);
            //get an object of Shape Rounded Rectangle
            Color shape1 = shapeFactory.getColor("RECTANGLE", "red");
            //call draw method of Shape Rectangle
            sb.AppendLine(shape1.draw());
            //get an object of Shape Rounded Square
            Color shape2 = shapeFactory.getColor("SQUARE", "green");
            //call draw method of Shape Square
            sb.AppendLine(shape2.draw());
            //get rounded shape factory
            AbstractFactory shapeFactory1 = FactoryProducer.getFactory(false);
            //get an object of Shape Rectangle
            Models._5.Factory.Shape shape3 = shapeFactory1.getShape("RECTANGLE");
            //call draw method of Shape Rectangle
            sb.AppendLine(shape3.draw());
            //get an object of Shape Square
            Models._5.Factory.Shape shape4 = shapeFactory1.getShape("SQUARE");
            //call draw method of Shape Square
            sb.AppendLine(shape4.draw());
            return sb.ToString();
        }

    }
}
