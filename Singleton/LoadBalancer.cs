namespace DesignPatterns.Singleton
{
    public class LoadBalancer
    {
        private static object obj = new object();
        private static LoadBalancer _instance;
        private LoadBalancer() { }

        public static LoadBalancer GetInstance()
        {
            lock (obj)
            {
                if (LoadBalancer._instance != null)
                    return _instance;
            
                return (_instance = new LoadBalancer());
            }
        }
    }
}
