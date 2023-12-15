using MedicalSystem.Model.Enums;

namespace MedicalSystem.Api.V1.Models.Auth;

public class RegistrateRequest
{
    public string Login { get; set; }

    public string Email { get; set; }

    public UserRole UserRole { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Password { get; set; }
}
