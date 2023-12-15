using MedicalSystem.Model.Enums;
using System;

namespace MedicalSystem.Api.V1.Models.User;

public class UserResponse
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public UserRole UserRole { get; set; }

    public DateTime RecCreated { get; set; }

    public DateTime RecModified { get; set; }
}
