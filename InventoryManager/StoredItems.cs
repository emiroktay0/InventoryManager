using InventoryManager.Item;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class StoredItems
    {
        public int SlotId { get; set; }
        public  List<ItemData> Store { get; set; } = new List<ItemData>();

        public StoredItems() { }


        public void ItemCreator(int Id, int SlotId)
        {

            switch (Id)
            {
                case 1:
                    ItemData hp = new HealthPotion();
                    hp.SlotId = SlotId;
                    Store.Add(hp);
                    break;
                case 2:
                    ManaPotion mana = new ManaPotion();
                    mana.SlotId = SlotId;
                    Store.Add(mana);
                    break;
                case 3:
                    GoldenSword goldenSword = new GoldenSword();
                    goldenSword.SlotId = SlotId;
                    Store.Add(goldenSword);
                    break;
                case 4:
                    Longbow longbow = new Longbow();
                    longbow.SlotId = SlotId;
                    Store.Add(longbow);
                    break;
                case 5:
                    IronArmor ironArmor = new IronArmor();
                    ironArmor.SlotId = SlotId;
                    Store.Add(ironArmor);
                    break;
                case 6:
                    ChainmailArmor chainmailArmor = new ChainmailArmor();
                    chainmailArmor.SlotId = SlotId;
                    Store.Add(chainmailArmor);
                    break;
            }

        }

        public void RemoveItem(int SlotId)
        {
            try
            {
                foreach (var item in Store)
                {
                    if (item.SlotId == SlotId)
                    {
                        Store.Remove(item);
                    }
                }
            }catch (Exception ex)
            {
            }
        }



    }
}
