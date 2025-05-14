
namespace Memento
{
    public class EditorMemento
    {
        public string Text { get; }
        public EditorMemento(string text) => Text = text;
    }

    public class TextEditor
    {
        private string content = "";
        private Stack<EditorMemento> history = new();

        public void Type(string newText)
        {
            history.Push(new EditorMemento(content));
            content += newText;
        }

        public void Undo()
        {
            if (history.Count > 0)
                content = history.Pop().Text;
        }

        public void Print() => Console.WriteLine($"[Editor] {content}");
    }
}
