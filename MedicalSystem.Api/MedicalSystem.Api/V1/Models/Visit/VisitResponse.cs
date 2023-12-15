using MedicalSystem.Model.Enums;
using System;

namespace MedicalSystem.Api.V1.Models.Visit;

public class VisitResponse
{
    public Guid Id { get; set; }

    public Guid PatientId { get; set; }

    public Guid DoctorId { get; set; }

    public Urgency Urgency { get; set; }

    public bool IsVisited { get; set; }

    public DateTime VisitDate { get; set; }

    public DateTime RecCreated { get; set; }

    public DateTime RecModified { get; set; }
}
