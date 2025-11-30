amespace RPGInventorySystem.Core.Items.Builders
{
    public interface IItemBuilder
    {
        IItemBuilder SetName(string name);
        IItemBuilder SetValue(int value); 
        Item Build();
    }
}
