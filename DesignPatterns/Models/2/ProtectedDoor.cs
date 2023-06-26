namespace DesignPatterns.Models._2
{
    public class ProtectedDoor : Door, PasswordClient
    {
        private PasswordProtector passwordProtector ;

        public ProtectedDoor(PasswordProtector passwordProtector)
        {
            this.passwordProtector = passwordProtector;
        }

        public void alarm()
        {
            
        }

        public void register(int code)
        {
            passwordProtector.Register(code, this);
        }
        public void check(int code)
        {
            passwordProtector.check(code);
        }
    }
}
