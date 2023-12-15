using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Threading;
using MedicalSystem.Api.V1.Models;
using System.Collections.Generic;
using MedicalSystem.Api.V1.Models.PrescribedTreatment;
using MedicalSystem.Api.V1.Models.Filters;

namespace MedicalSystem.Api.V1.Controllers;

[Route("v1/prescribedTreatments")]
public class PrescribedTreatmentController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ApiRequest<List<PrescribedTreatmentResponse>>>> GetAsync(
        [FromBody] ApiRequest<Filters> request,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiRequest<PrescribedTreatmentResponse>>> GetByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPost("create")]
    public async Task<ActionResult<ApiRequest<PrescribedTreatmentResponse>>> CreateAsync(
        [FromBody] ApiRequestBase<UpdatePrescribedTreatmentRequest> request,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiRequest<PrescribedTreatmentResponse>>> UpdateAsync(
        [FromBody] ApiRequestBase<UpdatePrescribedTreatmentRequest> request,
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiRequest<PrescribedTreatmentResponse>>> DeleteAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }
}
