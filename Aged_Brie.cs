namespace csharp
{
    public class Aged_Brie : CustomItem
    {
        private readonly Item item;

        public Aged_Brie(Item item) {
            this.item = item;
        }

        public void updateState() {
            increaseQuality();
            DecreaseSellIn();
        }
        

        private void DecreaseSellIn(){
            item.SellIn -= 1;
        }

        private void increaseQuality() {
            if (item.SellIn > 0)
                item.Quality += 1;
            else
                item.Quality += 2;
        }
    }
}