namespace Lab2.AbstractFactory
{
    public class AbstractFactoryDemo
    {
        public static void Run()
        {
            ITechFactory[] factories = new ITechFactory[]
            {
                new IProneFactory(),
                new KiaomiFactory(),
                new BalaxyFactory()
            };

            foreach (var factory in factories)
            {
                Console.WriteLine("---- Factory ----");
                Console.WriteLine(factory.CreateLaptop()?.GetDetails());
                Console.WriteLine(factory.CreateNetbook()?.GetDetails());
                Console.WriteLine(factory.CreateEBook()?.GetDetails());
                Console.WriteLine(factory.CreateSmartphone()?.GetDetails());
            }
        }
    }
}
