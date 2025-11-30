using System;

namespace RPGInventorySystem.Core.Items.States
{
    public class InventoryState : IItemState
    {
        public void Handle(Item item)
        {
            Console.WriteLine($"{item.Name} сейчас находится в инвентаре.");
        }
    }
}
