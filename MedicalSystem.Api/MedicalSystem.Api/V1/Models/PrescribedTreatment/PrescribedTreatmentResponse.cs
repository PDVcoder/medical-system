using System;

namespace MedicalSystem.Api.V1.Models.PrescribedTreatment;

public class PrescribedTreatmentResponse
{
    public Guid Id { get; set; }

    public Guid MedicalRecordId { get; set; }

    public string DrugName { get; set; }

    public string Dosage { get; set; }

    public string TakingSchedule { get; set; }

    public DateTime ReqCreated { get; set; }

    public DateTime ReqModified { get; set; }
}
