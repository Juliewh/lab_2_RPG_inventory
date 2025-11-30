using System;

namespace RPGInventorySystem.Core.Items.Strategies
{
    public class EquipStrategy : IItemUseStrategy
    {
        public void Use(IItem item)
        {
            Console.WriteLine($"Предмет '{item.Name}' был экипирован. Вы выглядите грозно!");
        }
    }
}
