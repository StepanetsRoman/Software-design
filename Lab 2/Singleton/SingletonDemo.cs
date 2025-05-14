namespace Lab2.Singleton
{
    public class SingletonDemo
    {
        public static void Run()
        {
            var auth1 = Authenticator.Instance;
            auth1.Login("admin");

            var auth2 = Authenticator.Instance;
            Console.WriteLine($"Second access sees user: {auth2.User}");

            Console.WriteLine($"Same instance: {ReferenceEquals(auth1, auth2)}");
        }
    }
}
