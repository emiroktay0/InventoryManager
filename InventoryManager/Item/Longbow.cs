using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Item
{
    public class Longbow : ItemData
    {
        public int Id = 4;


       

        public enumItemType ItemType = enumItemType.Weapon;

        public Longbow() : base("Long Bow", "9 Attack Damage, Value = 300 gold")
        {
        }
    }
}
