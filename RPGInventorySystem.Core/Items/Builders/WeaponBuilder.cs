namespace RPGInventorySystem.Core.Items.Builders
{
    public class WeaponBuilder : IItemBuilder
    {
        private string _name;
        private int _damage;

        public IItemBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public IItemBuilder SetValue(int value)
        {
            _damage = value;
            return this;
        }

        public Item Build()
        {
            return new Weapon(_name, _damage);
        }
    }
}
