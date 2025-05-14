using Lab2.FactoryMethod;
using Lab2.AbstractFactory;
using Lab2.Singleton;
using Lab2.Prototype;
using Lab2.Builder;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Фабричний метод ===");
            Console.ResetColor();
            FactoryMethodDemo.Run();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=== Абстрактна фабрика ===");
            Console.ResetColor();
            AbstractFactoryDemo.Run();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n=== Одинак (Singleton) ===");
            Console.ResetColor();
            SingletonDemo.Run();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n=== Прототип ===");
            Console.ResetColor();
            PrototypeDemo.Run();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Будівельник ===");
            Console.ResetColor();
            BuilderDemo.Run();
        }
    }
}
