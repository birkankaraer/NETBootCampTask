namespace WebAPI4.DAL
{
    public class WebUser
    {
        public int Id { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public List<Order> Order { get; set; }
    }
}
