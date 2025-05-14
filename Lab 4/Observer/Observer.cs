
namespace Observer
{
    public interface IEventListener
    {
        void Update(string eventType, string elementName);
    }

    public class ClickListener : IEventListener
    {
        public void Update(string eventType, string elementName)
        {
            Console.WriteLine($"[ClickListener] Подія '{eventType}' на елементі {elementName}");
        }
    }

    public class LightElementNode
    {
        private string name;
        private Dictionary<string, List<IEventListener>> listeners = new();

        public LightElementNode(string name)
        {
            this.name = name;
        }

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!listeners.ContainsKey(eventType))
                listeners[eventType] = new();
            listeners[eventType].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            if (listeners.ContainsKey(eventType))
                foreach (var listener in listeners[eventType])
                    listener.Update(eventType, name);
        }
    }
}
