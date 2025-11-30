using RPGInventorySystem.Core.Items.Builders;

namespace RPGInventorySystem.Core.Items.Factories
{
    public class FantasyItemFactory : IItemFactory
    {
        public IItem CreateWeapon()
        {
            return new WeaponBuilder().SetName("Excalibur").SetValue(100).Build();
        }

        public IItem CreateArmor()
        {
            return new ArmorBuilder().SetName("Mithril Mail").SetValue(50).Build();
        }

        public IItem CreatePotion()
        {
            return new Potion("Healing Potion", 20);
        }
    }
}
