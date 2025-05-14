using Interfaces;
using Classes;

namespace Classes
{
    public static class Reporting
    {
        public static void PrintIncomingInvoice(IProduct product, int quantity, DateTime date)
        {
            Console.WriteLine("=== Прибуткова накладна ===");
            Console.WriteLine($"Дата: {date:dd.MM.yyyy}");
            Console.WriteLine($"Товар: {product.Name}");
            Console.WriteLine($"Категорія: {product.Category}");
            Console.WriteLine($"Кількість: {quantity} {product.Unit}");
            Console.WriteLine($"Ціна за одиницю: {product.Price}");
            Console.WriteLine($"Загальна сума: {CalcTotal(product.Price, quantity)}");
        }

        public static void PrintOutgoingInvoice(IProduct product, int quantity, DateTime date)
        {
            Console.WriteLine("=== Витратна накладна ===");
            Console.WriteLine($"Дата: {date:dd.MM.yyyy}");
            Console.WriteLine($"Товар: {product.Name}");
            Console.WriteLine($"Категорія: {product.Category}");
            Console.WriteLine($"Кількість: {quantity} {product.Unit}");
            Console.WriteLine($"Ціна за одиницю: {product.Price}");
            Console.WriteLine($"Загальна сума: {CalcTotal(product.Price, quantity)}");
            Console.WriteLine("===========================");
        }

        public static void PrintInventory(List<(IProduct Product, int Quantity)> inventory)
        {
            Console.WriteLine("=== Інвентаризація складу ===");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Product.Name} — {item.Quantity} {item.Product.Unit} — {item.Product.Price}");
            }
            Console.WriteLine("=============================");
        }

        private static string CalcTotal(Money price, int quantity)
        {
            int totalKopecks = (price.Hryvnias * 100 + price.Kopecks) * quantity;
            var total = new Money(totalKopecks / 100, totalKopecks % 100, price.Currency);
            return total.ToString();
        }
    }
}
