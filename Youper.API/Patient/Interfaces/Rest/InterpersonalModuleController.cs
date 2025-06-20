using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Youper.API.Patient.Application.Internal.CommandServices;
using Youper.API.Patient.Application.Internal.QueryServices;
using Youper.API.Patient.Domain.Model.Commands;
using Youper.API.Patient.Domain.Model.Queries;

namespace Youper.API.Patient.Interfaces.Rest;

[ApiController]
[Route("api/v1/interpersonalModule")]
[Produces(MediaTypeNames.Application.Json)]
public class InterpersonalModuleController : ControllerBase
{
    private readonly InterpersonalModuleCommandService _commandService;
    private readonly InterpersonalModuleQueryService _queryService;

    public InterpersonalModuleController(
        InterpersonalModuleCommandService commandService,
        InterpersonalModuleQueryService queryService)
    {
        _commandService = commandService;
        _queryService = queryService;
    }

    [HttpPost("items")]
    public async Task<IActionResult> Post([FromBody] CreateInterpersonalItemCommand command)
    {
        var result = await _commandService.Handle(command);
        return result != null
            ? Ok(result)
            : StatusCode(500, "The item could not be saved.");
    }

    [HttpGet("items")]
    public async Task<IActionResult> Get()
    {
        var result = await _queryService.HandleAsync(new GetAllInterpersonalItemsQuery());
        return Ok(result);
    }
}