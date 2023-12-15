using MedicalSystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalSystem.Data.Models;

public class Visit
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

    [Required]
    public Urgency Urgency { get; set; }

    [Required]
    public DateTime VisitDate { get; set; }

    [Required]
    public bool IsVisited { get; set; } = false;

    [Required]
    [ReadOnly(true)]
    [DataType(DataType.DateTime)]
    public DateTime ReqCreated { get; set; } = DateTime.Now;

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime ReqModified { get; set; } = DateTime.Now;

    public ICollection<MedicalRecord> MedicalRecords { get; set; }
}
