using MedicalSystem.Api.V1.Models.User;
using System;

namespace MedicalSystem.Api.V1.Models.Patient;

public class PatientResponse : UserResponse
{
    public Guid? PatientId { get; set; }

    public DateTime? PatientRecCreated { get; set; }

    public DateTime? PatientRecModified { get; set; } 
}
