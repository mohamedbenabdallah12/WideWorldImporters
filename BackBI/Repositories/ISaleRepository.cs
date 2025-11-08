
using BackBI.Models;
namespace BackBI.Repository
{
        public interface ISaleRepository
        {
            Task<IEnumerable<Sale>> GetAllAsync();
            Task<Sale?> GetByIdAsync(int id);
            Task<IEnumerable<Sale>> GetByBillCustomerIdAsync(int billCustomerId);
            Task<IEnumerable<Sale>> GetByCustomerIdAsync(int customerId);
            Task<IEnumerable<Sale>> GetByContactPersonIdAsync(int contactPersonId);
            Task<IEnumerable<Sale>> GetBySalesPersonIdAsync(int salesPersonId);
            Task<IEnumerable<Sale>> GetByStockItemIdAsync(int stockItemId);
            Task<IEnumerable<Sale>> GetByDateKeyAsync(DateTime dateKey);
            Task<IEnumerable<Sale>> GetByPackageTypeIdAsync(int packageTypeId);
            Task<IEnumerable<Sale>> GetByMethodDeliveryIdAsync(int methodDeliveryId);

        }
    }


