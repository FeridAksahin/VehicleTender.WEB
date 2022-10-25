namespace VehicleTender.Web.AdminUI.Models.Token
{
    public class SingletonToken
    {

        private SingletonToken() { }
        private static SingletonToken instance = null;
        public static SingletonToken Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonToken();
                }
                return instance;
            }
        }
        public Token Token{get;set;} 

    }
}
