using System;
using System.Collections.Generic;
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

    public ICollection<MedicalRecord> PatientMedicalRecords { get; set; }
    public ICollection<Visit> Visits { get; set; }
}
