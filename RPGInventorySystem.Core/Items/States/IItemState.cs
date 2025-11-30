namespace RPGInventorySystem.Core.Items.States
{
    public interface IItemState
    {
        void Handle(Item item);
    }
}
