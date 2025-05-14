namespace Lab2.Prototype
{
    public class PrototypeDemo
    {
        public static void Run()
        {
            var parent = new Virus("Alpha", 0.2f, 1, "RNA");
            var child1 = new Virus("Beta", 0.1f, 1, "RNA");
            var child2 = new Virus("Gamma", 0.1f, 1, "RNA");

            parent.Children.Add(child1);
            parent.Children.Add(child2);

            Console.WriteLine("Original:");
            parent.Display();

            var cloned = parent.Clone();
            Console.WriteLine("\nCloned:");
            cloned.Display();
        }
    }
}
