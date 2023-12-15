using System;

namespace MedicalSystem.Api.V1.Models.PrescribedTreatment;

public class UpdatePrescribedTreatmentRequest
{
    public Guid MedicalRecordId { get; set; }

    public string DrugName { get; set; }

    public string Dosage { get; set; }

    public string TakingSchedule { get; set; }
}
