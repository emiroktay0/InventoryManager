using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Item
{
    public class GoldenSword : ItemData
    {
        public int Id = 3;

        public enumItemType ItemType = enumItemType.Weapon;

        public GoldenSword() : base("Golden Sword", "35 Attack Damage, Value = 500 gold")
        {
        }
    }
}
