using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HappyTravel.Sunpu.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/supplier-priorities")]
    [Produces("application/json")]
    [Authorize]
    public class SupplierPriorityController : BaseController
    {
        public SupplierPriorityController(ISupplierPriorityService supplierPriorityService)
        {
            _supplierPriorityService = supplierPriorityService;
        }


        /// <summary>
        /// Gets a list of priority suppliers by priority type
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        [HttpGet("")]
        [ProducesResponseType(typeof(SupplierPriorityByTypes), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPriority(CancellationToken cancellationToken)
            => OkOrBadRequest(await _supplierPriorityService.GetPriority(cancellationToken));


        /// <summary>
        /// Modified a list of prioritiy suppliers by priority type
        /// </summary>
        /// <param name="supplierPriorityByTypes">List of prioritiy suppliers by priority type</param>
        /// <param name="cancellationToken">Cancellation token</param>
        [HttpPut("")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ModifyPriority([FromBody] SupplierPriorityByTypes supplierPriorityByTypes, CancellationToken cancellationToken)
            => NoContentOrBadRequest(await _supplierPriorityService.ModifyPriority(supplierPriorityByTypes, cancellationToken));


        private readonly ISupplierPriorityService _supplierPriorityService;
    }
}
