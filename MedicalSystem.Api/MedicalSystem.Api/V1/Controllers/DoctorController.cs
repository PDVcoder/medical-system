using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Threading;
using MedicalSystem.Api.V1.Models;
using MedicalSystem.Api.V1.Models.Doctor;
using System.Collections.Generic;
using MedicalSystem.Api.V1.Models.Filters;

namespace MedicalSystem.Api.V1.Controllers;

[Route("v1/doctors")]
public class DoctorController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ApiResponse<List<DoctorResponse>>>> GetAsync(
        [FromBody] ApiRequest<Filters> request,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<DoctorResponse>>> GetByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPost("create")]
    public async Task<ActionResult<ApiResponse<DoctorResponse>>> CreateAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<DoctorResponse>>> UpdateAsync(
        [FromBody] ApiRequestBase<UpdateDoctorRequest> request,
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<DoctorResponse>>> DeleteAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }
}
