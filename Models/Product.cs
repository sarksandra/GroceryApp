namespace Models
{
    public class Product
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public short CategoryId { get; set; }
        public int CategoryName { get; set; }

    }
    public class Offer
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public Color BgColor { get; set; }

        private static string[] LightColor => new string[]
        {
            "#e1f1e7", "#dad1f9", "#ffff00", "#d0f200", "#e28083", "#7fbdc7", "#ea978d"
        };

        private static Color RandomColor => Color.FromHex(LightColor.OrderBy(c => Guid.NewGuid()).First());

        public static IEnumerable<Offer> GetOffers()
        {
            

        }
    }


}
