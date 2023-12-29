namespace WebAPI4.DAL
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public List<WebUser> WebUser { get; set; }

    }
}
