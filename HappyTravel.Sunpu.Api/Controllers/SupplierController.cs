using HappyTravel.Sunpu.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HappyTravel.Sunpu.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/suppliers")]
    [Produces("application/json")]
    public class SupplierController : BaseController
    {
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }


        /// <summary>
        /// Gets a list of suppliers
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>List of suppliers</returns>
        [HttpGet]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
        {
            return Ok("Empty list");
        }


        private readonly ISupplierService _supplierService;
    }
}
