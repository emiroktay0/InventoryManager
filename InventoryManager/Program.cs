using InventoryManager;

public class Program
{

    public static void Main(string[] args)
    {
        
            Menu menu = new Menu();
            StoredItems storage = new StoredItems();
            Inventory inventory = menu.InventoryProp();
            menu.MenuUI(storage, inventory);
            
        




    }

}