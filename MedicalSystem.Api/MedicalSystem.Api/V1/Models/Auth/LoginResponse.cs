using System;

namespace MedicalSystem.Api.V1.Models.Auth;

public class LoginResponse
{
    public Guid Id { get; set; }

    public string Login { get; set; }

    public string Token { get; set; }
}
