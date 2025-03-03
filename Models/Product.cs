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


}
