namespace RPGInventorySystem.Core.Items.Factories
{
    public interface IItemFactory
    {
        IItem CreateWeapon();
        IItem CreateArmor();
        IItem CreatePotion();
    }
}
