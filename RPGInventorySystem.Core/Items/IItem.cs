using RPGInventorySystem.Core.Items.Types;

namespace RPGInventorySystem.Core.Items
{
    public interface IItem
    {
        string Name { get; }
        ItemType Type { get; }
        int Value { get; set; } 
        void Use();
        string GetDescription();
    }
}
