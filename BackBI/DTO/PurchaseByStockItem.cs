using System.ComponentModel.DataAnnotations.Schema;

namespace BackBI.DTO
{
    public class PurchaseByStockItem
    {
        public string StockItemName { get; set; }

        public int TotalOrderedOuters { get; set; }

       
        public decimal TotalAmount { get; set; }
    }
}
