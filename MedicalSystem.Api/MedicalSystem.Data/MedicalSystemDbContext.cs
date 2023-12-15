using MedicalSystem.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalSystem.Data;

/// <summary>
/// MedicalSystemDbContext
/// </summary>
/// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
public class MedicalSystemDbContext : DbContext
{
    /// <summary>
    /// Gets or sets the users.
    /// </summary>
    public DbSet<User> Users { get; set; }

    /// <summary>
    /// Gets or sets the patients.
    /// </summary>
    public DbSet<Patient> Patients { get; set; }

    /// <summary>
    /// Gets or sets the doctors.
    /// </summary>
    public DbSet<Doctor> Doctors { get; set; }

    /// <summary>
    /// Gets or sets the visits.
    /// </summary>
    public DbSet<Visit> Visits { get; set; }

    /// <summary>
    /// Gets or sets the medical records.
    /// </summary>
    public DbSet<MedicalRecord> MedicalRecords { get; set; }

    /// <summary>
    /// Gets or sets the prescribed treatments.
    /// </summary>
    public DbSet<PrescribedTreatment> PrescribedTreatments { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MedicalSystemDbContext"/> class.
    /// </summary>
    /// <param name="dbContextOptions">The database context options.</param>
    public MedicalSystemDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
}
