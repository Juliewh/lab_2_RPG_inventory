using RPGInventorySystem.Core.Items;

namespace RPGInventorySystem.Core.Items.Strategies
{
    public interface IItemUseStrategy
    {
        void Use(IItem item);
    }
}
