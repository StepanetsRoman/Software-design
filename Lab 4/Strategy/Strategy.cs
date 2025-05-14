
namespace Strategy
{
    public interface IImageLoadingStrategy
    {
        void Load(string source);
    }

    public class LocalImageLoader : IImageLoadingStrategy
    {
        public void Load(string source)
        {
            Console.WriteLine($"Завантажено з локального шляху: {source}");
        }
    }

    public class WebImageLoader : IImageLoadingStrategy
    {
        public void Load(string source)
        {
            Console.WriteLine($"Завантажено з веб: {source}");
        }
    }

    public class Image
    {
        private IImageLoadingStrategy strategy;

        public Image(IImageLoadingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IImageLoadingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Display(string source)
        {
            strategy.Load(source);
        }
    }
}
