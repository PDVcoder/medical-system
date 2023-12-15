using MedicalSystem.Api.V1.Models;
using MedicalSystem.Api.V1.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MedicalSystem.Api.V1.Controllers;

[Route("v1/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("register")]
    public async Task<ActionResult<ApiResponse<LoginResponse>>> RegisterAsync(
        [FromBody] ApiRequestBase<RegistrateRequest> request, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult<ApiResponse<LoginResponse>>> LoginAsync(
        [FromBody] ApiRequestBase<LoginRequest> request, 
        CancellationToken cancellationToken = default)
    {
        return this.Ok();
    }

    [HttpPost("logout")]
    public async Task<ActionResult<ApiResponseBase>> LogoutAsync(
        CancellationToken cancellationToken = default)
    {
        return this.Ok(); ;
    }
}
