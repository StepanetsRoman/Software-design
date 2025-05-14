namespace Lab2.Builder
{
    public class Character
    {
        public string Name = "";
        public string Hair = "";
        public string Eyes = "";
        public List<string> Items = new();

        public void Show()
        {
            Console.WriteLine($"Character: {Name}, Hair: {Hair}, Eyes: {Eyes}, Items: {string.Join(", ", Items)}");
        }
    }
}
