namespace Assignment1.Model
{
    public class Bill
    {
        public int BillId { get; set; }
        public int TableNo { get; set; }
        public double TotalCost { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
