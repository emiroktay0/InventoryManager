namespace InventoryManager.Item
{
    public class ItemData
    {
        public int Id { get; set; }

        public int SlotId { get; set; }
        public string ItemName { get; set; }

        public string Attributes { get; set; }
        public enumItemType ItemType { get; set; }

        public ItemData(String name, String att)
        {
            ItemName = name;
            Attributes = att;

        }
    }

    public enum enumItemType
    {
        Potion,
        Weapon,
        Armor
    }

    
}
