using HappyTravel.Sunpu.Api.Models;
using HappyTravel.Sunpu.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
    [ProducesResponseType(typeof(List<SlimSupplier>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        return Ok(await _supplierService.Get(cancellationToken));
    }


    /// <summary>
    /// Gets a supplier by id
    /// </summary>
    /// <param name="supplierId">Supplier id</param>
    /// <param name="cancellationToken">Сancellation token</param>
    /// <returns></returns>
    [HttpGet("supplierId")]
    [ProducesResponseType(typeof(SupplierData), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get([FromRoute] int supplierId, CancellationToken cancellationToken)
    {
        return Ok(await _supplierService.Get(supplierId, cancellationToken));
    }


    private readonly ISupplierService _supplierService;
}
