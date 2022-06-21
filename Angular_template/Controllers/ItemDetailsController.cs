using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_template.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemDetailsController : ControllerBase
    {
        private readonly ILogger<ItemDetailsController> _logger;
        public ItemDetailsController(ILogger<ItemDetailsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetItemDetails")]
        public IEnumerable<ItemDetails> Get()
        {
            var rng = new Random();
            int ivale = 0;
            return Enumerable.Range(1, 10).Select(index => new ItemDetails
            {
                ItemCode = "ITM_" + rng.Next(1, 100),
                SaleCount = rng.Next(20, 100),
            }).ToArray(); ;
        }
    }
}
