using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MedicalSystem.Data.Models;

public class Patient
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    // Patient foreign key
    [Required]
    [ForeignKey("User")]
    public Guid UserId { get; set; }
    public User User { get; set; }

    [Required]
    [ReadOnly(true)]
    [DataType(DataType.DateTime)]
    public DateTime RecCreated { get; set; } = DateTime.Now;

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime RecModified { get; set; } = DateTime.Now;

    public ICollection<MedicalRecord> PatientMedicalRecords { get; set; }
    public ICollection<Visit> Visits { get; set; }
}
