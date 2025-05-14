namespace Lab2.Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHair(string hair)
        {
            _character.Hair = hair;
            return this;
        }

        public ICharacterBuilder SetEyes(string eyes)
        {
            _character.Eyes = eyes;
            return this;
        }

        public ICharacterBuilder AddItem(string item)
        {
            _character.Items.Add(item);
            return this;
        }

        public Character Build() => _character;
    }
}
