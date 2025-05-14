using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Money
    {
        public int Hryvnias { get; }
        public int Kopecks { get; }
        public string Currency { get; }

        public Money(int hryvnias, int kopecks, string currency = "грн")
        {
            int total = hryvnias * 100 + kopecks;
            Hryvnias = total / 100;
            Kopecks = total % 100;
            Currency = currency;
        }

        public Money Subtract(Money other)
        {
            int total1 = Hryvnias * 100 + Kopecks;
            int total2 = other.Hryvnias * 100 + other.Kopecks;
            int result = Math.Max(0, total1 - total2);
            return new Money(result / 100, result % 100, Currency);
        }

        public override string ToString()
        {
            return $"{Hryvnias},{Kopecks:D2} {Currency}";
        }
    }
}

