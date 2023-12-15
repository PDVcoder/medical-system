using MedicalSystem.Model.Enums;
using System;

namespace MedicalSystem.Api.V1.Models.Visit;

public class UpdateVisitRequest
{
    public Guid PatientId { get; set; }

    public Guid DoctorId { get; set; }

    public Urgency Urgency { get; set; }

    public bool IsVisited { get; set; }
}
