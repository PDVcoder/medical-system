using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MedicalSystem.Data.Models;

public class Doctor
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
    public string Specialization { get; set; }

    public ICollection<MedicalRecord> DoctorMedicalRecords { get; set; }
    public ICollection<Visit> Visits { get; set; }

}
