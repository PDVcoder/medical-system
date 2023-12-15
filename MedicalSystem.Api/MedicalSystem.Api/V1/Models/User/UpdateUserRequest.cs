namespace MedicalSystem.Api.V1.Models.User;

public class UpdateUserRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string CurrentPassword { get; set; }

    public string NewPassword { get; set; }
}
