using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        private static readonly List<string> Legendaries = new List<string>() { "Sulfuras, Hand of Ragnaros" };
        private static readonly List<string> AgedCheeses = new List<string>() { "Aged Brie" };
        private static readonly List<string> BackstagePasses = new List<string>() { "Backstage passes to a TAFKAL80ETC concert" };

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Legendaries.Contains(Items[i].Name)) { continue; }
                if (AgedCheeses.Contains(Items[i].Name))
                {
                    Items[i].Quality++;
                }
                else if (BackstagePasses.Contains(Items[i].Name))
                {
                    Items[i].Quality++;

                    if (Items[i].SellIn < 11)
                    {
                        Items[i].Quality++;
                    }

                    if (Items[i].SellIn < 6)
                    {
                        Items[i].Quality++;
                    }
                }
                else
                {
                    Items[i].Quality--;
                }

                Items[i].SellIn--;


                if (Items[i].SellIn < 0)
                {
                    if (AgedCheeses.Contains(Items[i].Name))
                    {
                        Items[i].Quality++;
                    }
                    else if (BackstagePasses.Contains(Items[i].Name))
                    {
                        Items[i].Quality = 0;
                    }
                    else
                    {
                        Items[i].Quality--;
                    }
                }
                if (Items[i].Quality < 0) { Items[i].Quality = 0; }
                else if (Items[i].Quality > 50) { Items[i].Quality = 50; }
            }
        }
    }
}
