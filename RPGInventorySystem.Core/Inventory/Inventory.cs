using System.Collections.Generic;
using System.Linq;
using RPGInventorySystem.Core.Items;

namespace RPGInventorySystem.Core.Inventory
{
    public class Inventory
    {
        private List<IItem> _items;
        public int Count => _items.Count;

        public Inventory()
        {
            _items = new List<IItem>();
        }

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            _items.Remove(item);
        }

        public IItem GetItem(int index)
        {
            if (index >= 0 && index < _items.Count)
                return _items[index];
            return null;
        }

        public void UpgradeItem(IItem item, int amount)
        {
            item.Value += amount;
        }

        public IEnumerable<IItem> GetAllItems()
        {
            return _items;
        }
    }
}
