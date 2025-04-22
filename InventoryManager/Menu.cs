
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    internal class Menu 
    {
        public Menu()
        {
            
        }

        public void MenuUI(StoredItems Store, Inventory inventory)
        {
            int Key = 0;
            while (Key != 5)
            {
                inventory.Init();
                Console.WriteLine();
                Console.WriteLine("=====================================");
                Console.WriteLine("Please choose operation: ");
                Console.WriteLine("1. Select slot");
                Console.WriteLine("2. Show items in current slot");
                Console.WriteLine("3. Add item(s)");
                Console.WriteLine("4. Remove item");
                Console.WriteLine("5. Exit");
                Console.WriteLine("=====================================");
                string input = Console.ReadLine();
                

                if (int.TryParse(input, out Key))
                {
                    Console.WriteLine("Key: " + Key);
                }
                else
                    Console.WriteLine("Invalid input.");

                Option(Key, Store, inventory);

            }

            Console.WriteLine("Program terminated.");

        }
        public Inventory InventoryProp()
        {
            Console.Write("Please enter inventory width: ");
          
            string input1 = Console.ReadLine();
            int Width = int.Parse(input1);


            Console.Write("Please enter inventory height: ");
           
            string input2 = Console.ReadLine();
            int Height = int.Parse(input2);


            Inventory inventory = new Inventory(Width, Height);
            

            return inventory;

        }

        public void Option(int Key, StoredItems Storage, Inventory inventory)
        {
            switch (Key)
            {
                case 1:
                    Console.WriteLine("Write slot number: ");
                    string input1 = Console.ReadLine();
                    int SlotNum = int.Parse(input1);

                    inventory.CurrentSlotId = SlotNum;
                    break;
                
                case 2:
                    int count = 0;
                    foreach (var item in Storage.Store)
                    {
                        
                        if (item.SlotId == inventory.CurrentSlotId)
                        { 
                            count++;
                            Console.WriteLine(item.ItemName + ": " + item.Attributes);
                        }
                    }
                    if(count == 0)
                        Console.WriteLine("This slot is empty.");
                    Console.WriteLine("------------------------------");
                    break;

                case 3:
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Choose item: ");
                    Console.WriteLine("1.Health Potion");
                    Console.WriteLine("2.Mana Potion");
                    Console.WriteLine("3.Golden Sword");
                    Console.WriteLine("4.Long Bow");
                    Console.WriteLine("5.Iron Armor");
                    Console.WriteLine("6.Chainmail Armor");
                    string input2 = Console.ReadLine();
                    int ItemNum = int.Parse(input2);

                    Storage.ItemCreator(ItemNum, inventory.CurrentSlotId);
                    Console.WriteLine("Item added successfully.");
                    Console.WriteLine("-------------------------------");
                   
                    break;
                case 4:
                    Console.WriteLine("------------------------------");

                    Storage.RemoveItem(inventory.CurrentSlotId);

                    Console.WriteLine("Items in current slot are removed.");
                    Console.WriteLine("------------------------------");
                    break;
            }
        }


    }
}
