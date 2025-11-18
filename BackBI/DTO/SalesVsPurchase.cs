namespace BackBI.DTO
{
    public class SalesVsPurchase
    {
        public int StockItemKey { get; set; }
        public string StockItemName { get; set; }

        // Ventes
        public int TotalSalesQuantity { get; set; }
        public decimal TotalSalesAmount { get; set; }

        // Achats
        public int TotalPurchaseQuantity { get; set; }
        public decimal TotalPurchaseAmount { get; set; }

        // Comparaisons
        public int QuantityDifference { get; set; }
        public decimal AmountDifference { get; set; }

        // Ratio ventes / achats
        public double? SalesToPurchaseRatio { get; set; }
    }
}
