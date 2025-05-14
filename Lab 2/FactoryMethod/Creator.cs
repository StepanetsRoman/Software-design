namespace Lab2.FactoryMethod
{
    public abstract class Creator
    {
        public abstract Subscription CreateSubscription(string type);
    }

    public class WebSite : Creator
    {
        public override Subscription CreateSubscription(string type)
        {
            return type switch
            {
                "Domestic" => new DomesticSubscription(),
                "Educational" => new EducationalSubscription(),
                "Premium" => new PremiumSubscription(),
                _ => throw new ArgumentException("Invalid subscription type")
            };
        }
    }

    public class MobileApp : Creator
    {
        public override Subscription CreateSubscription(string type)
        {
            Console.WriteLine("Created via Mobile App");
            return new PremiumSubscription();
        }
    }

    public class ManagerCall : Creator
    {
        public override Subscription CreateSubscription(string type)
        {
            Console.WriteLine("Created via Manager Call");
            return new DomesticSubscription();
        }
    }
}
