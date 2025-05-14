using Interfaces;

namespace Classes
{
    public class Warehouse
    {
        private List<(IProduct Product, int Quantity)> _inventory = new();

        public void Incoming(IProduct product, int quantity, DateTime date)
        {
            var existing = _inventory.FirstOrDefault(i => i.Product.Name == product.Name);
            if (existing.Product != null)
            {
                _inventory.Remove(existing);
                _inventory.Add((existing.Product, existing.Quantity + quantity));
            }
            else
            {
                _inventory.Add((product, quantity));
            }

            Reporting.PrintIncomingInvoice(product, quantity, date);
        }

        public void Outgoing(string productName, int quantity, DateTime date)
        {
            var existing = _inventory.FirstOrDefault(i => i.Product.Name == productName);
            if (existing.Product != null && existing.Quantity >= quantity)
            {
                _inventory.Remove(existing);
                _inventory.Add((existing.Product, existing.Quantity - quantity));

                Reporting.PrintOutgoingInvoice(existing.Product, quantity, date);
            }
            else
            {
                Console.WriteLine($"Помилка: недостатньо товару {productName} на складі.");
            }
        }

        public List<(IProduct Product, int Quantity)> GetInventory()
        {
            return _inventory;
        }
    }
}
