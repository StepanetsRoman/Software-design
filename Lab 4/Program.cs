
using ChainOfResponsibility;
using Mediator;
using Observer;
using Strategy;
using Memento;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Посередник ===");
        var cc = new CommandCentre();
        var rw1 = new Runway("1");
        cc.AddRunway(rw1);
        var plane = new Aircraft("F16", cc);
        plane.RequestLanding();

        Console.WriteLine("\n=== Ланцюжок відповідальностей ===");
        var m1 = new VoiceMenu("1");
        var m2 = new VoiceMenu("2");
        m1.SetNext(m2);
        m1.HandleRequest("1: Підтримка");

        Console.WriteLine("\n=== Спостерігач ===");
        var span = new LightElementNode("span");
        span.AddEventListener("mouseover", new ClickListener());
        span.TriggerEvent("mouseover");

        Console.WriteLine("\n=== Стратегія ===");
        var image = new Image(new WebImageLoader());
        image.Display("http://example.com/image.jpg");

        Console.WriteLine("\n=== Мементо ===");
        var ed = new TextEditor();
        ed.Type("Це варіант 1. ");
        ed.Type("І ще щось.");
        ed.Print();
        ed.Undo();
        ed.Print();
    }
}
