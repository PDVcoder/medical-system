using MedicalSystem.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace MedicalSystem.Api.V1.Models.MedicalRecord;

public class UpdateMedicalRecordRequest
{
    public Guid PatientId { get; set; }

    public Guid DoctorId { get; set; }

    public Guid? VisitId { get; set; }

    [Required]
    public string Symptoms { get; set; }

    [Required]
    public string Diagnosis { get; set; }

    [Required]
    public string PrescribedTreatmentDescription { get; set; }

}
