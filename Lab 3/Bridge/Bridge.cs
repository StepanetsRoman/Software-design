
namespace Bridge
{
    public interface IRenderer
    {
        void Render(string shape);
    }

    public class RasterRenderer : IRenderer
    {
        public void Render(string shape) => Console.WriteLine($"Малюю {shape} пікселями");
    }

    public class VectorRenderer : IRenderer
    {
        public void Render(string shape) => Console.WriteLine($"Малюю {shape} векторами");
    }

    public abstract class Shape
    {
        protected IRenderer renderer;
        protected Shape(IRenderer renderer) => this.renderer = renderer;
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }
        public override void Draw() => renderer.Render("Коло");
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }
        public override void Draw() => renderer.Render("Квадрат");
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) { }
        public override void Draw() => renderer.Render("Трикутник");
    }
}
