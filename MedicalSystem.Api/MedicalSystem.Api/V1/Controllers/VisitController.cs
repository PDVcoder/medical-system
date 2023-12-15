using MedicalSystem.Api.V1.Models;
using MedicalSystem.Api.V1.Models.Filters;
using MedicalSystem.Api.V1.Models.Visit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MedicalSystem.Api.V1.Controllers;

[Route("v1/visits")]
public class VisitController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ApiResponse<List<VisitResponse>>>> GetAsync(
        [FromBody] ApiRequest<Filters> filters,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<VisitResponse>>> GetByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPost("plan")]
    public async Task<ActionResult<ApiResponse<VisitResponse>>> PlanAsync(
        [FromBody] ApiRequestBase<UpdateVisitRequest> update,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<VisitResponse>>> UpdateAsync(
        [FromBody] ApiRequestBase<UpdateVisitRequest> update,
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<VisitResponse>>> CancelAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }
}
