using System;
using System.Collections.Generic;
using Interfaces;
using Classes;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        {
            IProduct cheese = new Product("Сир твердий", "кг", new Money(115, 75, "UAH"), "Молочні продукти");
            IProduct eggs = new Product("Яйця", "дюжина", new Money(30, 00, "UAH"), "Продукти тваринного походження");

            var warehouse = new Warehouse();
            warehouse.Incoming(cheese, 50, DateTime.Now);
            warehouse.Incoming(eggs, 120, DateTime.Now);

            Reporting.PrintIncomingInvoice(cheese, 50, DateTime.Now);
            Reporting.PrintIncomingInvoice(eggs, 120, DateTime.Now);

            warehouse.Outgoing("Сир твердий", 10, DateTime.Now);
            warehouse.Outgoing("Яйця", 40, DateTime.Now);

            Reporting.PrintOutgoingInvoice(cheese, 10, DateTime.Now);
            Reporting.PrintOutgoingInvoice(eggs, 40, DateTime.Now);

            var inventory = warehouse.GetInventory();
            Reporting.PrintInventory(inventory);
        }
    }
}
