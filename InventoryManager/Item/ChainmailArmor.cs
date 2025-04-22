using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Item
{
    public class ChainmailArmor : ItemData
    {
        public int Id = 6;

        public enumItemType ItemType = enumItemType.Armor;

        public ChainmailArmor() : base("Chainmail Armor", "8 Damage Protection, Value = 600 gold")
        {
        }
    }
}
