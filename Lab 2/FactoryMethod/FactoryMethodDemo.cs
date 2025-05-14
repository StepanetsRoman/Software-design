namespace Lab2.FactoryMethod
{
    public class FactoryMethodDemo
    {
        public static void Run()
        {
            Creator website = new WebSite();
            var sub1 = website.CreateSubscription("Educational");
            Console.WriteLine(sub1);

            Creator app = new MobileApp();
            var sub2 = app.CreateSubscription("Premium");
            Console.WriteLine(sub2);

            Creator call = new ManagerCall();
            var sub3 = call.CreateSubscription("Domestic");
            Console.WriteLine(sub3);
        }
    }
}
