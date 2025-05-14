namespace Lab2.Builder
{
    public class BuilderDemo
    {
        public static void Run()
        {
            var hero = new HeroBuilder()
                .SetName("Artemis")
                .SetHair("Blonde")
                .SetEyes("Green")
                .AddItem("Bow")
                .AddItem("Cape")
                .Build();

            hero.Show();
        }
    }
}
