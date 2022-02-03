using System.Collections.Generic;

namespace csharp
{
    public class Conjured_Item : StandardItem
    {
        public Conjured_Item(Item item) : base(item)
        {
        }

        public override int DecreaseQuality()
        {
            return 2;
        }
    }
}