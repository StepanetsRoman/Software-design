
namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML();
        public abstract string InnerHTML();
    }

    public class LightTextNode : LightNode
    {
        private string text;
        public LightTextNode(string text) => this.text = text;

        public override string OuterHTML() => text;
        public override string InnerHTML() => text;
    }

    public class LightElementNode : LightNode
    {
        private string tagName;
        private string displayType;
        private bool isSingle;
        private List<string> cssClasses;
        private List<LightNode> children;

        public LightElementNode(string tagName, string displayType, bool isSingle)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.isSingle = isSingle;
            cssClasses = new();
            children = new();
        }

        public void AddClass(string className) => cssClasses.Add(className);
        public void AddChild(LightNode node) => children.Add(node);

        public override string OuterHTML()
        {
            string classStr = cssClasses.Count > 0 ? $" class='{string.Join(" ", cssClasses)}'" : "";
            string openTag = $"<{tagName}{classStr}>";
            string closeTag = isSingle ? "" : $"</{tagName}>";

            return openTag + InnerHTML() + closeTag;
        }

        public override string InnerHTML()
        {
            return string.Join("", children.Select(c => c.OuterHTML()));
        }
    }
}
