
namespace ChainOfResponsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler? next;
        public void SetNext(SupportHandler handler) => next = handler;
        public abstract void HandleRequest(string request);
    }

    public class VoiceMenu : SupportHandler
    {
        private string level;
        public VoiceMenu(string level) => this.level = level;

        public override void HandleRequest(string request)
        {
            if (request.Contains(level))
                Console.WriteLine($"[VoiceMenu-{level}] Оброблено запит: {request}");
            else
                next?.HandleRequest(request);
        }
    }
}
