using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalSystem.Data.Models;

public class MedicalRecord
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    // Patient foreign key
    [Required]
    [ForeignKey("Patient")]
    public Guid PatientId { get; set; }
    public Patient Patient { get; set; }

    // Doctor foreign key
    [Required]
    [ForeignKey("Doctor")]
    public Guid DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    // MedicalRecord foreign key
    [Required]
    [ForeignKey("Visit")]
    public Guid? VisitId { get; set; }
    public Visit Visit { get; set; }

    [Required]
    public string Symptoms { get; set; }

    [Required]
    public string Diagnosis { get; set; }

    [Required]
    public string PrescribedTreatmentDescription { get; set; }

    [Required]
    [ReadOnly(true)]
    [DataType(DataType.DateTime)]
    public DateTime ReqCreated { get; set; } = DateTime.Now;

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime ReqModified { get; set; } = DateTime.Now;

    public PrescribedTreatment PrescribedTreatment { get; set; }
}
