namespace Lab2.FactoryMethod
{
    public abstract class Subscription
    {
        public abstract string Name { get; }
        public abstract decimal MonthlyFee { get; }
        public abstract int MinimumPeriodMonths { get; }
        public abstract string[] Features { get; }

        public override string ToString()
        {
            return $"{Name}: {MonthlyFee}$/month for {MinimumPeriodMonths} months. Features: {string.Join(", ", Features)}";
        }
    }

    public class DomesticSubscription : Subscription
    {
        public override string Name => "Domestic";
        public override decimal MonthlyFee => 9.99m;
        public override int MinimumPeriodMonths => 3;
        public override string[] Features => new[] { "Basic Channels", "Local News" };
    }

    public class EducationalSubscription : Subscription
    {
        public override string Name => "Educational";
        public override decimal MonthlyFee => 5.99m;
        public override int MinimumPeriodMonths => 1;
        public override string[] Features => new[] { "Science", "Documentaries", "E-learning" };
    }

    public class PremiumSubscription : Subscription
    {
        public override string Name => "Premium";
        public override decimal MonthlyFee => 19.99m;
        public override int MinimumPeriodMonths => 6;
        public override string[] Features => new[] { "All Channels", "No Ads", "4K Streaming" };
    }
}
