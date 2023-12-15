using MedicalSystem.Api.V1.Models.User;
using System;

namespace MedicalSystem.Api.V1.Models.Doctor;

public class DoctorResponse : UserResponse
{
    public Guid? DoctorId { get; set; }

    public string Specialization { get; set; }

    public DateTime? DoctorRecCreated { get; set; }

    public DateTime? DoctorRecModified { get; set; } 
}
