using Interfaces;

namespace Classes
{
    public class Product : IProduct
    {
        public string Name { get; }
        public string Unit { get; }
        public Money Price { get; private set; }
        public string Category { get; }

        public Product(string name, string unit, Money price, string category)
        {
            Name = name;
            Unit = unit;
            Price = price;
            Category = category;
        }

        public void ReducePrice(Money amount)
        {
            int totalKopecks = Price.Hryvnias * 100 + Price.Kopecks;
            int discountKopecks = amount.Hryvnias * 100 + amount.Kopecks;
            totalKopecks = Math.Max(0, totalKopecks - discountKopecks);
            Price = new Money(totalKopecks / 100, totalKopecks % 100, Price.Currency);
        }

        public string GetInfo()
        {
            return $"{Name} ({Category}) — {Price} за {Unit}";
        }
    }
}
