using MedicalSystem.Api.V1.Models.User;

namespace MedicalSystem.Api.V1.Models.Doctor;

public class UpdateDoctorRequest : UpdateUserRequest
{
    public string Specialization { get; set; }

}
