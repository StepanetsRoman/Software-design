using Classes;


namespace Interfaces
{
    public interface IProduct
    {
        string Name { get; }
        string Unit { get; }
        Money Price { get; }
        string Category { get; }

        void ReducePrice(Money amount);
        string GetInfo();
    }
}
