using BackBI.DTO;

namespace BackBI.Repositories
{
    public interface IPurchaseRepository
    {
        Task<List<Purchase_Ordered_vs_Received>> GetPurchase_Ordered_vs_Received();

        Task<List<PurchaseBySupplier>> GetPurchaseBySuppliers();

        Task<List<PurchaseByStockItem>> GetPurchaseByStockItems();

        Task<List<PurchaseByPackageType>> GetPurchaseByPackageType();

        Task<List<SalesVsPurchase>> GetSalesVsPurchase();
    }
}
