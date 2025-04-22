using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Item
{


    public class HealthPotion : ItemData
    {

        public int Id = 1;
        public int SlotId { get; set; }

        public enumItemType ItemType = enumItemType.Potion;

        public HealthPotion() : base("Health Potion", "+25 HP, Value = 100 gold")
        {
        }
    }
}
