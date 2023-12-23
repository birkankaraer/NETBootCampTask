namespace WebAPI2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        public Category Category { get; set; }
    }
}
