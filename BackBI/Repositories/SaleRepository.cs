using BackBI.DTO;
using BackBI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackBI.Repository
{
    public class SaleRepository : ISaleRepository
    {
        private readonly DWContext _context;

        public SaleRepository(DWContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sale>> GetAllAsync()
        {
            return await _context.Sales.ToListAsync();
        }

        public async Task<Sale> GetByIdAsync(int id)
        {
            return await _context.Sales.FirstOrDefaultAsync(s => s.InvoiceId == id);
        }

        public async Task<IEnumerable<Sale>> GetByBillCustomerIdAsync(int billCustomerId)
        {
            return await _context.Sales
                .Where(s => s.BillToCustomerId == billCustomerId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetByCustomerIdAsync(int customerId)
        {
            return await _context.Sales
                .Where(s => s.CustomerId == customerId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetByContactPersonIdAsync(int contactPersonId)
        {
            return await _context.Sales
                .Where(s => s.ContactPersonId == contactPersonId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetBySalesPersonIdAsync(int salesPersonId)
        {
            return await _context.Sales
                .Where(s => s.SalespersonPersonId == salesPersonId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetByStockItemIdAsync(int stockItemId)
        {
            return await _context.Sales
                .Where(s => s.StockItemId == stockItemId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetByDateKeyAsync(DateTime dateKey)
        {
            return await _context.Sales
                .Where(s => s.InvoiceDateKey == dateKey)
                .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetByPackageTypeIdAsync(int packageTypeId)
        {
            return await _context.Sales
                .Where(s => s.PackageTypeId == packageTypeId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetByMethodDeliveryIdAsync(int methodDeliveryId)
        {
            return await _context.Sales
                .Where(s => s.DeliveryMethodId == methodDeliveryId)
                .ToListAsync();
        }
        // fonctions d’agrégation
        public async Task<IEnumerable<object>> GetSalesByDayAsync()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.Sales
                .Join(_context.Dates,
                      s => s.InvoiceDateKey,
                      d => d.Date1,
                      (s, d) => new { s, d })
                .GroupBy(x => x.d.Date1)
                .Select(g => new
                {
                    Day = g.Key,
                    TotalSales = g.Sum(x => x.s.Quantity * x.s.UnitPrice)
                })
                .OrderBy(g => g.Day)
                .ToListAsync();
        }
        public async Task<List<SalesByMonth>> GetSalesByMonthAsync()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.SalesByMonth
                .OrderBy(x => x.Month)
                .ToListAsync();
        }

        public async Task<List<SalesByYears>> GetSalesByYears()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.SalesByYears
                .OrderBy(x => x.Years)
                .ToListAsync();
        }

        public async Task<List<SalesByEmployeeYear>> GetSalesByEmployeeYear()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.SalesByEmployeeYear
                .OrderBy(x => x.Years)
                .ToListAsync();
        }

        public async Task<List<SalesByDeliveryMethodYear>> GetSalesByDeliveryMethodYear()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.SalesByDeliveryMethodYear.ToListAsync();
        }

        public async Task<List<SalesByPackageType>> GetSalesByPackageType()
        {
            _context.Database.SetCommandTimeout(180);
            return await _context.SalesByPackageType.ToListAsync();
        }

       

    }

}
