using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        private GildedRose app;
        private IList<Item> Items;

        [SetUp]
        public void Setup()
        {
            // ARRANGE
            Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                // this conjured item does not work properly yet
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            app = new GildedRose(Items);
        }
        [Test]
        public void Name_Check()
        {
            // ACT
            app.UpdateQuality();
            // ASSERT
            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
        }

        [Test]
        public void Aged_Brie_Update()
        {
            // ACT
            app.UpdateQuality();
            // ASSERT
            Assert.AreEqual(1, Items[1].Quality);
        }
        [Test]
        public void Aged_Brie_15XUpdate()
        {
            // ACT
            for (var i = 0; i < 15; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual(28, Items[1].Quality);
        }
        
        [Test]
        public void Concert_Ticket_15XUpdate()
        {
            // ACT
            for (var i = 0; i < 16; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual(0, Items[5].Quality);
        }
        
        
        
        [Test]
        public void Concert_Ticket_13XUpdate()
        {
            // ACT
            for (var i = 0; i < 13; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual(44, Items[5].Quality);
        }
        
        [Test]
        public void Concert_Ticket_Max50_Update()
        {
            // ACT
            app.UpdateQuality();
            // ASSERT
            Assert.AreEqual(50, Items[7].Quality);
        }
        
        [Test]
        public void Sulfuras_5XUpdate_Quality_check()
        {
            // ACT
            for (var i = 0; i < 5; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual(80, Items[3].Quality);
        }
        
        [Test]
        public void Sulfuras_5XUpdate_SellIn_check()
        {
            // ACT
            for (var i = 0; i < 5; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual( -1, Items[4].SellIn);
        }
        
        [Test]
        public void Mongoose_7XUpdate_SellIn_check()
        {
            // ACT
            for (var i = 0; i < 7; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual( -2, Items[2].SellIn);
        }
        
        [Test]
        public void Mongoose_5XUpdate_Quality_check()
        {
            // ACT
            for (var i = 0; i < 5; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual( 2, Items[2].Quality);
        }
        
        [Test]
        public void DexVest_12XUpdate_Quality_check()
        {
            // ACT
            for (var i = 0; i < 12; i++)
            {
                app.UpdateQuality();
            }
            // ASSERT
            Assert.AreEqual( 6, Items[0].Quality);
        }
        
        
    }
}
