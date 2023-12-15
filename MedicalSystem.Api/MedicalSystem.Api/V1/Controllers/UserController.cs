using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Collections.Generic;
using MedicalSystem.Api.V1.Models;
using MedicalSystem.Api.V1.Models.User;
using MedicalSystem.Api.V1.Models.Filters;

namespace MedicalSystem.Api.V1.Controllers;

[Route("v1/users")]
public class UserController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ApiResponse<List<UserResponse>>>> GetAsync(
        [FromBody] ApiRequest<Filters> request,
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<UserResponse>>> GetByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<UserResponse>>> UpdateAsync(
        [FromBody] ApiRequest<UpdateUserRequest, Filters> request,
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<UserResponse>>> DeleteAsync(
        Guid id, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }
}
