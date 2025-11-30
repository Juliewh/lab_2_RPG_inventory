using NUnit.Framework;
using RPGInventorySystem.Core.Inventory;
using RPGInventorySystem.Core.Items;
using RPGInventorySystem.Core.Items.Builders;
using RPGInventorySystem.Core.Items.Factories;
using RPGInventorySystem.Core.Items.States;
using System.Linq;

namespace RPGInventorySystem.Tests
{
    public class InventoryTests
    {
        private Inventory _inventory;

        [SetUp]
        public void Setup()
        {
            _inventory = new Inventory();
        }

        [Test]
        public void Test_AddItem_ShouldIncreaseCount()
        {
            var weapon = new WeaponBuilder().SetName("Sword").SetValue(10).Build();

            _inventory.AddItem(weapon);

            Assert.AreEqual(1, _inventory.Count);
        }

        [Test]
        public void Test_Factory_ShouldCreateCorrectItems()
        {
            IItemFactory factory = new FantasyItemFactory();

            var weapon = factory.CreateWeapon();

            Assert.IsNotNull(weapon);
            Assert.IsInstanceOf<Weapon>(weapon);
            Assert.AreEqual("Excalibur", weapon.Name);
        }

        [Test]
        public void Test_Strategy_PotionShouldConsume()
        {
            var potion = new Potion("Heal", 50);

            potion.Use();

            Assert.IsInstanceOf<InventoryState>(potion.State);
        }

        [Test]
        public void Test_State_WeaponShouldEquip()
        {
            var weapon = new Weapon("Axe", 20);

            weapon.Use(); 

            Assert.IsInstanceOf<EquippedState>(weapon.State);
        }

        [Test]
        public void Test_UpgradeItem_ShouldIncreaseValue()
        {
            var armor = new Armor("Plate", 100);
            _inventory.AddItem(armor);

            _inventory.UpgradeItem(armor, 20);
            
            Assert.AreEqual(120, armor.Value);
        }
    }
}
