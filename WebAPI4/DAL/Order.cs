using Microsoft.EntityFrameworkCore;

namespace WebAPI4.DAL
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        [Precision(9, 2)]
        public decimal TotalPrice { get; set; }
        public List<WebUser> WebUser { get; set; } = new();

    }
}
