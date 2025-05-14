namespace Lab2.Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHair(string hair);
        ICharacterBuilder SetEyes(string eyes);
        ICharacterBuilder AddItem(string item);
        Character Build();
    }
}
