using BackBI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackBI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleRepository _repository;

        public SaleController(ISaleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sales = await _repository.GetAllAsync();
            return Ok(sales);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sale = await _repository.GetByIdAsync(id);
            if (sale == null) return NotFound();
            return Ok(sale);
        }
        [HttpGet("by-bill-customer/{billCustomerId}")]
        public async Task<IActionResult> GetByBillCustomerId(int billCustomerId)
        {
            var sales = await _repository.GetByBillCustomerIdAsync(billCustomerId);
            return Ok(sales);
        }

        [HttpGet("by-customer/{customerId}")]
        public async Task<IActionResult> GetByCustomerId(int customerId)
        {
            var sales = await _repository.GetByCustomerIdAsync(customerId);
            return Ok(sales);
        }

        [HttpGet("by-contact-person/{contactPersonId}")]
        public async Task<IActionResult> GetByContactPersonId(int contactPersonId)
        {
            var sales = await _repository.GetByContactPersonIdAsync(contactPersonId);
            return Ok(sales);
        }

        [HttpGet("by-sales-person/{salesPersonId}")]
        public async Task<IActionResult> GetBySalesPersonId(int salesPersonId)
        {
            var sales = await _repository.GetBySalesPersonIdAsync(salesPersonId);
            return Ok(sales);
        }

        [HttpGet("by-stock-item/{stockItemId}")]
        public async Task<IActionResult> GetByStockItemId(int stockItemId)
        {
            var sales = await _repository.GetByStockItemIdAsync(stockItemId);
            return Ok(sales);
        }

        [HttpGet("by-date/{dateKey}")]
        public async Task<IActionResult> GetByDateKey(DateTime dateKey)
        {
            var sales = await _repository.GetByDateKeyAsync(dateKey);
            return Ok(sales);
        }

        [HttpGet("by-package-type/{packageTypeId}")]
        public async Task<IActionResult> GetByPackageTypeId(int packageTypeId)
        {
            var sales = await _repository.GetByPackageTypeIdAsync(packageTypeId);
            return Ok(sales);
        }

        [HttpGet("by-method-delivery/{methodDeliveryId}")]
        public async Task<IActionResult> GetByMethodDeliveryId(int methodDeliveryId)
        {
            var sales = await _repository.GetByMethodDeliveryIdAsync(methodDeliveryId);
            return Ok(sales);
        }



    }
}
