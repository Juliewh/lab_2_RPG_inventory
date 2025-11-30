using RPGInventorySystem.Core.Items; 

namespace RPGInventorySystem.Core.Items.Builders
{
    public class ArmorBuilder : IItemBuilder
    {
        private string _name;
        private int _defense;

        public IItemBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        public IItemBuilder SetValue(int value)
        {
            _defense = value;
            return this;
        }

        public Item Build() 
        {
            return new Armor(_name, _defense);
        }
    }
}
