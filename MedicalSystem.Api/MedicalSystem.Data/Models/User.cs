using MedicalSystem.Model.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MedicalSystem.Data.Models;

public class User
{
    [Required]
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Login { get; set; }

    [Required]
    [StringLength(32)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(32)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(32)]
    public string Email { get; set; }

    [Required]
    [PasswordPropertyText]
    [DataType(DataType.Password)]
    public string PasswordHash { get; set; }

    [Required]
    public UserRole Role { get; set; }

    [Required]
    [ReadOnly(true)]
    [DataType(DataType.DateTime)]
    public DateTime RecCreated { get; set; } = DateTime.Now;
    
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime RecModified { get; set; } = DateTime.Now;

    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
}
