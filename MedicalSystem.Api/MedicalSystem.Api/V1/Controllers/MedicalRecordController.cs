using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Threading;
using MedicalSystem.Api.V1.Models;
using MedicalSystem.Api.V1.Models.MedicalRecord;
using System.Collections.Generic;
using MedicalSystem.Api.V1.Models.Filters;

namespace MedicalSystem.Api.V1.Controllers;

[Route("v1/medicalRecords")]
public class MedicalRecordController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ApiResponse<List<MedicalRecordResponse>>>> GetAsync(
        [FromBody] ApiRequest<Filters> request,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<MedicalRecordResponse>>> GetByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPost("create")]
    public async Task<ActionResult<ApiResponse<MedicalRecordResponse>>> CreateAsync(
        [FromBody] ApiRequestBase<UpdateMedicalRecordRequest> request,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<MedicalRecordResponse>>> UpdateAsync(
        [FromBody] ApiRequestBase<UpdateMedicalRecordRequest> request, 
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<MedicalRecordResponse>>> DeleteAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }
}
