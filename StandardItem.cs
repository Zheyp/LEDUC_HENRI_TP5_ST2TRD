namespace csharp
{
    public class StandardItem : CustomItem
    {
        private readonly Item item;

        public StandardItem(Item item) {
            this.item = item;
        }

        public void updateState() {
            if (SellInOverZero()) {
                DecreaseQualityBy(DecreaseQuality());
            } else {
                DecreaseQualityBy(DecreaseQualitySubZeroSellIn());
            }
            Decrease_SellIn();
        }

        public virtual int DecreaseQuality() {
            return 1;
        }

        private void Decrease_SellIn() {
            item.SellIn -= 1;
        }

        private bool SellInOverZero() {
            return item.SellIn > 0;
        }

        private void DecreaseQualityBy(int qualityValue) {
            item.Quality -= qualityValue;
        }

        private int DecreaseQualitySubZeroSellIn() {
            return DecreaseQuality() * 2;
        }
    }
}