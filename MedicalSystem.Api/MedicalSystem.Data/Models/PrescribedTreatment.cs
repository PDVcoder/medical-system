using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace MedicalSystem.Data.Models;

public class PrescribedTreatment
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    // MedicalRecord foreign key
    [Required]
    [ForeignKey("MedicalRecord")]
    public Guid MedicalRecordId { get; set; }
    public MedicalRecord MedicalRecord { get; set; }

    [Required]
    public string DrugName { get; set; }

    [Required]
    public string Dosage { get; set; }

    [Required]
    public string TakingSchedule { get; set; }

    [Required]
    [ReadOnly(true)]
    [DataType(DataType.DateTime)]
    public DateTime ReqCreated { get; set; } = DateTime.Now;

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime ReqModified { get; set; } = DateTime.Now;
}
