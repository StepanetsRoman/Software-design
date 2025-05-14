
using Composite;

namespace Flyweight
{
    public class HtmlElementFactory
    {
        private Dictionary<string, LightElementNode> cache = new();

        public LightElementNode GetElement(string tag)
        {
            if (!cache.ContainsKey(tag))
            {
                cache[tag] = new LightElementNode(tag, "block", false);
            }
            return cache[tag];
        }
    }

    public class HtmlBuilder
    {
        private HtmlElementFactory factory = new();
        private List<LightNode> elements = new();

        public void BuildFromText(string[] lines)
        {
            foreach (var line in lines)
            {
                LightElementNode node;
                if (line == lines[0])
                    node = new LightElementNode("h1", "block", false);
                else if (line.StartsWith(" "))
                    node = new LightElementNode("blockquote", "block", false);
                else if (line.Length < 20)
                    node = new LightElementNode("h2", "block", false);
                else
                    node = new LightElementNode("p", "block", false);

                node.AddChild(new LightTextNode(line.Trim()));
                elements.Add(node);
            }
        }

        public void Display()
        {
            foreach (var e in elements)
                Console.WriteLine(e.OuterHTML());
        }

        public long GetMemoryUsage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            return GC.GetTotalMemory(true);
        }
    }
}
