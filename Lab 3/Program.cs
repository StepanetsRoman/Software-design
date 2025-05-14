
using Adapter;
using Decorator;
using Bridge;
using Proxy;
using Composite;
using Flyweight;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Адаптер ===");
        ITarget logger = new Logger();
        logger.Log("Це звичайне повідомлення");
        ITarget fileLogger = new FileLoggerAdapter();
        fileLogger.Error("Файл: помилка");

        Console.WriteLine("\n=== Декоратор ===");
        IHero hero = new Warrior();
        hero = new Sword(hero);
        hero = new Armor(hero);
        Console.WriteLine(hero.GetDescription());

        Console.WriteLine("\n=== Міст ===");
        Shape shape = new Triangle(new RasterRenderer());
        shape.Draw();

        Console.WriteLine("\n=== Проксі ===");
        var checker = new SmartTextChecker();
        checker.ReadFile("sample.txt");
        var locker = new SmartTextReaderLocker(".*restricted.*");
        locker.ReadFile("restricted.txt");

        Console.WriteLine("\n=== Компонувальник ===");
        var div = new LightElementNode("div", "block", false);
        div.AddClass("container");
        div.AddChild(new LightTextNode("Привіт з HTML!"));
        Console.WriteLine(div.OuterHTML());

        Console.WriteLine("\n=== Легковаговик ===");
        var builder = new HtmlBuilder();
        string[] lines = new[] {
            "Назва книги",
            " Короткий опис",
            "Довший параграф тексту, який містить багато слів і перевищує 20 символів."
        };
        builder.BuildFromText(lines);
        builder.Display();
        Console.WriteLine($"Використано памʼяті: {builder.GetMemoryUsage()} байт");
    }
}
