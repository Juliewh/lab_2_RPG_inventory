using RPGInventorySystem.Core.Items.Strategies;
using RPGInventorySystem.Core.Items.Types;

namespace RPGInventorySystem.Core.Items
{
    public class Armor : Item
    {
        public Armor(string name, int defense)
            : base(name, ItemType.Armor, new EquipStrategy())
        {
            Value = defense;
        }

        public override string GetDescription() => $"Броня: {Name}, Защита: {Value}";
    }
}
