namespace DesignPatterns.Models._2
{
    public class Door
    {
        private Boolean locked;

        public void lockDoor(){
            locked=true;
            Console.WriteLine("Door locked");
        }

        public void unlockDoor() { 
            locked = false;
            Console.WriteLine("Door Unlocked");
        }
    }
}
