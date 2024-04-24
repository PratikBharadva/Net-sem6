using System.Collections;
namespace Assignment1.Model
{
    public class Order
    {

        public int OrderId { get; set; }
        public int TableId { get; set; }
        public int Qty { get; set; }
        public int FoodId { get; set; }
        public Menu Food {  get; set; }
        public int BillId { get; set; }
        public Bill bills { get; set; }
        

    }
}
