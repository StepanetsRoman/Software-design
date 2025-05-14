namespace Lab2.Prototype
{
    public class Virus
    {
        public string Name;
        public float Weight;
        public int Age;
        public string Type;
        public List<Virus> Children = new();

        public Virus(string name, float weight, int age, string type)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Type = type;
        }

        public Virus Clone()
        {
            var clone = new Virus(Name, Weight, Age, Type);
            foreach (var child in Children)
                clone.Children.Add(child.Clone());
            return clone;
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}{Name} ({Type})");
            foreach (var child in Children)
                child.Display(indent + "  ");
        }
    }
}
