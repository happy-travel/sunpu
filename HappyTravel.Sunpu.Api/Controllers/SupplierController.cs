using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HappyTravel.Sunpu.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/{v:apiVersion}/suppliers")]
[Produces("application/json")]
[Authorize]
public class SupplierController : BaseController
{
    public SupplierController(ISupplierService supplierService)
    {
        _supplierService = supplierService;
    }


    /// <summary>
    /// Gets a list of suppliers
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of slim suppliers</returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<SlimSupplier>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
        => Ok(await _supplierService.Get(cancellationToken));


    /// <summary>
    /// Gets a supplier by id
    /// </summary>
    /// <param name="supplierCode">Supplier code</param>
    /// <param name="cancellationToken">Сancellation token</param>
    /// <returns>The supplier data</returns>
    [HttpGet("{supplierCode}")]
    [ProducesResponseType(typeof(RichSupplier), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get([FromRoute] string supplierCode, CancellationToken cancellationToken)
        => OkOrBadRequest(await _supplierService.Get(supplierCode, cancellationToken));


    /// <summary>
    /// Adds a new supplier 
    /// </summary>
    /// <param name="richSupplier">Supplier data</param>
    /// <param name="cancellationToken">Сancellation token</param>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] RichSupplier richSupplier, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Add(richSupplier, cancellationToken));


    /// <summary>
    /// Modifies an existing supplier
    /// </summary>
    /// <param name="richSupplier">New data for the supplier</param>
    /// <param name="cancellationToken">Сancellation token</param>
    /// <param name="supplierCode">Supplier code</param>
    [HttpPut("{supplierCode}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Modify([FromRoute] string supplierCode, [FromBody] RichSupplier richSupplier, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Modify(supplierCode, richSupplier, cancellationToken));


    /// <summary>
    /// Deletes a supplier
    /// </summary>
    /// <param name="supplierCode">Supplier code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    [HttpDelete("{supplierId:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete([FromRoute] string supplierCode, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Delete(supplierCode, cancellationToken));


    /// <summary>
    /// Activates specified supplier
    /// </summary>
    /// <param name="supplierCode">Code of the supplier</param>
    /// <param name="reason">Reason for activating the supplier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    [HttpPost("{supplierCode}/activate")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Activate([FromRoute] string supplierCode, [FromQuery] string reason, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Activate(supplierCode, reason, cancellationToken));


    /// <summary>
    /// Deactivates specified supplier
    /// </summary>
    /// <param name="supplierCode">Code of the supplier</param>
    /// <param name="reason">Reason for deactivating the supplier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    [HttpPost("{supplierCode}/deactivate")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Deactivate([FromRoute] string supplierCode, [FromQuery] string reason, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Deactivate(supplierCode, reason, cancellationToken));


    private readonly ISupplierService _supplierService;
}
