using System;

namespace RPGInventorySystem.Core.Items.Strategies
{
    public class ConsumeStrategy : IItemUseStrategy
    {
        public void Use(IItem item)
        {
            Console.WriteLine($"Вы выпили/использовали '{item.Name}'. Эффект применен!");
        }
    }
}
