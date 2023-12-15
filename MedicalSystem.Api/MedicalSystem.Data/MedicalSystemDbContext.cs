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
    /// Initializes a new instance of the <see cref="MedicalSystemDbContext"/> class.
    /// </summary>
    /// <param name="dbContextOptions">The database context options.</param>
    public MedicalSystemDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
}
