using RPGInventorySystem.Core.Items.Strategies;
using RPGInventorySystem.Core.Items.Types;

namespace RPGInventorySystem.Core.Items
{
    public class Potion : Item
    {
        public Potion(string name, int healAmount)
            : base(name, ItemType.Potion, new ConsumeStrategy())
        {
            Value = healAmount;
        }

        public override string GetDescription() => $"Зелье: {Name}, Лечение: {Value}";
    }
}
