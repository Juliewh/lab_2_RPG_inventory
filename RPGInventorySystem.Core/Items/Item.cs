using RPGInventorySystem.Core.Items.States;
using RPGInventorySystem.Core.Items.Strategies;
using RPGInventorySystem.Core.Items.Types;

namespace RPGInventorySystem.Core.Items
{
    public abstract class Item : IItem
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public int Value { get; set; } 

        protected IItemUseStrategy _useStrategy;

        public IItemState State { get; set; }

        public Item(string name, ItemType type, IItemUseStrategy strategy)
        {
            Name = name;
            Type = type;
            _useStrategy = strategy;
            State = new InventoryState(); 
        }

        public void Use()
        {
            _useStrategy.Use(this);
            if (_useStrategy is EquipStrategy)
            {
                State = new EquippedState();
            }
        }

        public abstract string GetDescription();
    }
}
