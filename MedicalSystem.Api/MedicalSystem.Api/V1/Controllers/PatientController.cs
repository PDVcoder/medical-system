using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Threading;
using MedicalSystem.Api.V1.Models;
using System.Collections.Generic;
using MedicalSystem.Api.V1.Models.Patient;
using MedicalSystem.Api.V1.Models.Filters;
using MedicalSystem.Api.V1.Models.User;

namespace MedicalSystem.Api.V1.Controllers;

[Route("v1/patients")]
public class PatientController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ApiResponse<List<PatientResponse>>>> GetAsync(
        [FromBody] ApiRequest<Filters> request,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<PatientResponse>>> GetByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPost("create")]
    public async Task<ActionResult<ApiResponse<PatientResponse>>> CreateAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<PatientResponse>>> UpdateAsync(
        [FromBody] ApiRequestBase<UpdateUserRequest> request,
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<PatientResponse>>> DeleteAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }
}
