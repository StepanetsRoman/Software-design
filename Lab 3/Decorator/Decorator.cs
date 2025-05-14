
namespace Decorator
{
    public interface IHero
    {
        string GetDescription();
    }

    public class Warrior : IHero
    {
        public string GetDescription() => "Воїн";
    }

    public class Mage : IHero
    {
        public string GetDescription() => "Маг";
    }

    public class Paladin : IHero
    {
        public string GetDescription() => "Паладін";
    }

    public abstract class EquipmentDecorator : IHero
    {
        protected IHero Hero;

        public EquipmentDecorator(IHero hero) => Hero = hero;

        public virtual string GetDescription() => Hero.GetDescription();
    }

    public class Sword : EquipmentDecorator
    {
        public Sword(IHero hero) : base(hero) { }
        public override string GetDescription() => base.GetDescription() + " зі Мечем";
    }

    public class Armor : EquipmentDecorator
    {
        public Armor(IHero hero) : base(hero) { }
        public override string GetDescription() => base.GetDescription() + " в Броні";
    }

    public class Artifact : EquipmentDecorator
    {
        public Artifact(IHero hero) : base(hero) { }
        public override string GetDescription() => base.GetDescription() + " з Артефактом";
    }
}
