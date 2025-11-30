using RPGInventorySystem.Core.Items.Strategies;
using RPGInventorySystem.Core.Items.Types;

namespace RPGInventorySystem.Core.Items
{
    public class Weapon : Item
    {
        public Weapon(string name, int damage)
            : base(name, ItemType.Weapon, new EquipStrategy())
        {
            Value = damage;
        }

        public override string GetDescription() => $"Меч: {Name}, Урон: {Value}";
    }
}
