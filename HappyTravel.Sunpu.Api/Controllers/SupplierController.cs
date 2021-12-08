using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace HappyTravel.Sunpu.Api.Controllers;

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
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of slim suppliers</returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<SlimSupplier>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
        => Ok(await _supplierService.Get(cancellationToken));


    /// <summary>
    /// Gets a supplier by id
    /// </summary>
    /// <param name="supplierId">Supplier id</param>
    /// <param name="cancellationToken">Сancellation token</param>
    /// <returns>The supplier data</returns>
    [HttpGet("{supplierId:int}")]
    [ProducesResponseType(typeof(SupplierData), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get([FromRoute] int supplierId, CancellationToken cancellationToken)
        => OkOrBadRequest(await _supplierService.Get(supplierId, cancellationToken));


    /// <summary>
    /// Adds a new supplier 
    /// </summary>
    /// <param name="supplierData">Supplier data</param>
    /// <param name="cancellationToken">Сancellation token</param>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] SupplierData supplierData, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Add(supplierData, cancellationToken));


    /// <summary>
    /// Modifies an existing supplier
    /// </summary>
    /// <param name="supplierData">New data for the supplier</param>
    /// <param name="cancellationToken">Сancellation token</param>
    /// <param name="supplierId">Supplier id</param>
    [HttpPut("{supplierId:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Modify([FromRoute] int supplierId, [FromBody] SupplierData supplierData, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Modify(supplierId, supplierData, cancellationToken));


    /// <summary>
    /// Deletes a supplier
    /// </summary>
    /// <param name="supplierId">Supplier id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    [HttpDelete("{supplierId:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete([FromRoute] int supplierId, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Delete(supplierId, cancellationToken));


    /// <summary>
    ///  Activates specified supplier
    /// </summary>
    /// <param name="supplierId">Id of the supplier</param>
    /// <param name="reason">Reason for activating the supplier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    [HttpPost("{supplierId}/activate")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Activate([FromRoute] int supplierId, [FromQuery] string reason, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Activate(supplierId, reason, cancellationToken));


    /// <summary>
    ///  Deactivates specified supplier
    /// </summary>
    /// <param name="supplierId">Id of the supplier</param>
    /// <param name="reason">Reason for activating the supplier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    [HttpPost("{supplierId}/deactivate")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Deactivate([FromRoute] int supplierId, [FromQuery] string reason, CancellationToken cancellationToken)
        => NoContentOrBadRequest(await _supplierService.Deactivate(supplierId, reason, cancellationToken));


    private readonly ISupplierService _supplierService;
}
