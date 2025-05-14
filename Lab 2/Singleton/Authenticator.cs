using System;

namespace Lab2.Singleton
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> instance = new Lazy<Authenticator>(() => new Authenticator());

        public static Authenticator Instance => instance.Value;

        public string User { get; private set; } = "Unknown";

        private Authenticator()
        {
            Console.WriteLine("Authenticator instance created");
        }

        public void Login(string username)
        {
            User = username;
            Console.WriteLine($"User '{username}' authenticated.");
        }
    }
}
