using System;

namespace RPGInventorySystem.Core.Items.States
{
    public class EquippedState : IItemState
    {
        public void Handle(Item item)
        {
            Console.WriteLine($"{item.Name} сейчас экипирован и дает бонусы.");
        }
    }
}
