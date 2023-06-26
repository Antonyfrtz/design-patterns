using DesignPatterns.Models._3.Components;

namespace DesignPatterns.Models._3
{
    public class PremiumCoffeeMachine : CoffeeMachine,EspressoMachine
    {
        private Dictionary<CoffeeSelection, Configuration> configMap;
        private Dictionary<CoffeeSelection, CoffeeBean> beans;
        private Grinder grinder;
        private BrewingUnit brewingUnit;

        PremiumCoffeeMachine(Dictionary<CoffeeSelection, CoffeeBean> beans)
        {
            this.beans = beans;
        }

        public Coffee brewEspresso()
        {
            return new Coffee();
        }

        public Coffee brewFilterCoffee()
        {
            return new Coffee();
        }

        public void addCoffeeBeans(CoffeeSelection selection, CoffeeBean newBeans)
        {

        }
    }
}
