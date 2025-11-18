using BackBI.Repositories;
using BackBI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackBI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseRepository _repository;

        public PurchaseController(IPurchaseRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("by-Purchase_Ordered_vs_Received")]
        public async Task<IActionResult> GetPurchase_Ordered_vs_Received()
        {
            var result = await _repository.GetPurchase_Ordered_vs_Received();
            return Ok(result);
        }
        [HttpGet("by-Purchase_BySupplier")]
        public async Task<IActionResult> GetPurchaseBySupplier()
        {
            var result = await _repository.GetPurchaseBySuppliers();
            return Ok(result);
        }
        [HttpGet("by-PurchaseByStockItems")]
        public async Task<IActionResult> GetPurchaseByStockItems()
        {
            var result = await _repository.GetPurchaseByStockItems();
            return Ok(result);
        }

        [HttpGet("by-PurchaseByPackageType")]
        public async Task<IActionResult> GetPurchaseByPackageType()
        {
            var result = await _repository.GetPurchaseByPackageType();
            return Ok(result);
        }
        [HttpGet("SalesVsPurchase")]
        public async Task<IActionResult> GetSalesVsPurchase()
        {
            var result = await _repository.GetSalesVsPurchase();
            return Ok(result);
        }
    }
}
