using DesignPatterns.Models._3.Components;

namespace DesignPatterns.Models._3
{
    public class BasicCoffeeMachine : CoffeeMachine
    {
        private Configuration configuration ;
        private Dictionary<CoffeeSelection, GroundCoffee> groundCoffee;
        private BrewingUnit brewingUnit;

        public BasicCoffeeMachine(Dictionary<CoffeeSelection,GroundCoffee> groundCoffee)
        {
            groundCoffee = groundCoffee;
            brewingUnit = new BrewingUnit();
            configuration = new Configuration();
        }

        public Coffee brewFilterCoffee()
        {           
            return new Coffee();
        }

        public void addGroundCoffee(CoffeeSelection selection, GroundCoffee newCoffee)
        {

        }
    }
}
