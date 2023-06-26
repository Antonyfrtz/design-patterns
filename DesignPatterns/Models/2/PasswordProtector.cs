namespace DesignPatterns.Models._2
{
    public class PasswordProtector
    {
        private int safeNumber = 0;
        private PasswordClient myClient;

        public void Register(int code, PasswordClient client)
        {
            safeNumber = code;
            myClient = client;
        }
        public Boolean check(int code)
        {
            if(code!=this.safeNumber) {
                myClient.alarm();
                return false;
            }
            return true;
        }
    }
}
