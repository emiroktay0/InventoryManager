using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Item
{
    public class ManaPotion : ItemData
    {
        
        public int Id = 2;


        public enumItemType ItemType = enumItemType.Potion;

        public ManaPotion() : base("Mana Potion", "+100 Mana, Value = 50 gold")
        {
        }
    }
}
