namespace csharp
{
    public class Aged_Brie : CustomItem
    {
        private readonly Item item;

        public Aged_Brie(Item item) {
            this.item = item;
        }

        public void updateState() {
            DecreaseSellIn();
            increaseQuality();
        }
        

        private void DecreaseSellIn(){
            item.SellIn -= 1;
        }

        private void increaseQuality() {
            item.Quality += 1;
        }
    }
}