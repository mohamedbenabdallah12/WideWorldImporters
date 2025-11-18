namespace BackBI.DTO
{
    public class PurchaseBySupplier
    {
        public string SupplierName { get; set; }

        public decimal TotalPurchaseAmount { get; set; }

        public int TotalOrderedOuters { get; set; }

        public int NumberOfOrders { get; set; }

    }
}
