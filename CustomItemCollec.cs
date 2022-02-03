using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace csharp
{
    public class CustomItemCollec
    {
        private readonly static Dictionary<String, CustomItem> ITEM_TYPE_LIST = new Dictionary<String, CustomItem>();
        public readonly static String SULFURAS = "Sulfuras, Hand of Ragnaros";
        public readonly static String AGED_BRIE = "Aged Brie";
        public readonly static String CONCERT_TICKET = "Backstage passes to a TAFKAL80ETC concert";
        public readonly static String CONJURED_ITEM = "Conjured";

        public CustomItemCollec(Item item) {
            ITEM_TYPE_LIST.Add(SULFURAS, new Sulfuras());
            ITEM_TYPE_LIST.Add(AGED_BRIE, new Aged_Brie(item));
            ITEM_TYPE_LIST.Add(CONCERT_TICKET, new Concert_Ticket(item));
            ITEM_TYPE_LIST.Add(CONJURED_ITEM, new Conjured_Item(item));
        }

        public CustomItem CustomisedItem(Item item) {
            if (isStandardItem(item)) {
                return new StandardItem(item);  
            }
            return ITEM_TYPE_LIST[item.Name];
        }

        private bool isStandardItem(Item item) {
            return !ITEM_TYPE_LIST.ContainsKey(item.Name);
        }
    }
    }
