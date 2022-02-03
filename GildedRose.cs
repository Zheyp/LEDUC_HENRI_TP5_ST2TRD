using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private static readonly int MIN_QUALITY_VALUE = 0;
        IList<Item> Items;
        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (Item i in Items) {
                customisedItem(i).updateState();
                if (hasReachedMinQualityValue(i)) {
                    i.Quality = MIN_QUALITY_VALUE;
                } else if (hasReachedHighestQualityValue(i)) {
                    i.Quality = MaxValuePossible(i);
                }
            }
        }
        private CustomItem customisedItem(Item item) {
            return new CustomItemCollec(item).CustomisedItem(item);
        }

        private bool hasReachedMinQualityValue(Item item) {
            return item.Quality < MIN_QUALITY_VALUE;
        }

        private bool hasReachedHighestQualityValue(Item item) {
            return item.Quality > MaxValuePossible(item);
        }
        public static int MaxValuePossible(Item item) {
            if (item.Name.Equals(CustomItemCollec.SULFURAS)) {
                return 80;
            }
            return 50;
        }
    }
}
