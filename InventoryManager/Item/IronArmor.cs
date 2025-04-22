using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Item
{
    public class IronArmor : ItemData
    {
        public int Id = 5;


       

        public enumItemType ItemType = enumItemType.Armor;

        public IronArmor() : base("Iron Armor", "14 Damage Protection, Value = 1000 gold")
        {
        }
    }
}
