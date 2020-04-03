namespace UserService
{
    public class Order
    {
        public Order(int id, int orderAmount, string date)
        {
            OrderAmount = orderAmount;
            this.Date = date;
            OrderId = id;
        }

        public int OrderId { get; set; }
        public int OrderAmount
        {
            get; set;
        }
        public string Date
        {
            get; set;
        }
    }
}