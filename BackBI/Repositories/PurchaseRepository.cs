using BackBI.DTO;
using BackBI.Models;
using Microsoft.EntityFrameworkCore;

namespace BackBI.Repositories
{
    public class PurchaseRepository : IPurchaseRepository

    {
        private readonly DWContext _context;

        public PurchaseRepository(DWContext context)
        {
            _context = context;
        }

        public async Task<List<PurchaseByPackageType>> GetPurchaseByPackageType()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.PurchaseByPackageType.ToListAsync();
        }

        public async Task<List<PurchaseByStockItem>> GetPurchaseByStockItems()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.PurchaseByStockItem.ToListAsync();
        }

        public async Task<List<PurchaseBySupplier>> GetPurchaseBySuppliers()
        {

            _context.Database.SetCommandTimeout(180);
            return await _context.Purchase_BySupplier.ToListAsync();
        }

        public async Task<List<Purchase_Ordered_vs_Received>> GetPurchase_Ordered_vs_Received()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.Purchase_Ordered_vs_Received.ToListAsync();
        }

        public async Task<List<SalesVsPurchase>> GetSalesVsPurchase()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.SalesVsPurchase.ToListAsync();
        }
    }
}
