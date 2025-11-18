namespace BackBI.DTO
{
    public class Purchase_Ordered_vs_Received
    {
        public int PurchaseOrderID { get; set; }
        public int PurchaseOrderLineID { get; set; }
        public int StockItemID { get; set; }

        // Quantités
        public int OrderedOuters { get; set; }
        public int ReceivedOuters { get; set; }
        public int DifferenceOuters { get; set; }

        // Statut de livraison
        public string DeliveryStatus { get; set; }

        // Prix et montants
        public decimal ExpectedUnitPricePerOuter { get; set; }
        public decimal ExpectedAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
    }
}
