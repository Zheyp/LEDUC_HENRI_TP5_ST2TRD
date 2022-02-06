namespace csharp
{
    public class Concert_Ticket : CustomItem
    {
        private readonly Item item;

        public Concert_Ticket(Item item) {
            this.item = item;
        }

        public void updateState() {
            if (SellInOver(10)) {
                IncreaseQualityBy(1);
            } else if (SellInOver(5)) {
                IncreaseQualityBy(2);
            } else if (SellInOver(0)) {
                IncreaseQualityBy(3);
            } else {
                SetQualityToZero();
            }
            decreaseSellByDayValueByOne();
        }

        private void decreaseSellByDayValueByOne() {
            item.SellIn -= 1;
        }

        private bool SellInOver(int dayNumber) {
            return item.SellIn > dayNumber;
        }

        private void IncreaseQualityBy(int qualityValue) {
            item.Quality += qualityValue;
        }

        private void SetQualityToZero() {
            item.Quality = 0;
        }
    }
}