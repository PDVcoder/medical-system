using MedicalSystem.Data;
using MedicalSystem.Model.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

public class Repository<T> : IRepository<T> where T : class
{
    #region Properties

    private MedicalSystemDbContext _context;
    private DbSet<T> _dbSet;

    #endregion

    #region Constructor

    public Repository(MedicalSystemDbContext context)
    {
        this._context = context ?? throw new ArgumentNullException(nameof(context));
        this._dbSet = _context.Set<T>();
    }

    #endregion

    #region CRUD Methods

    public async Task<T> GetAsync(Guid? id, CancellationToken cancellationToken = default)
    {
        return await this._dbSet.FindAsync(new object[] { id }, cancellationToken);
    }

    public async Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await this._dbSet.ToListAsync(cancellationToken);
    }

    public async Task<ICollection<T>> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await this._dbSet.Where(expression).ToListAsync(cancellationToken);
    }

    public async Task DeleteAsync(Guid? id, CancellationToken cancellationToken = default)
    {
        var item = await this.GetAsync(id, cancellationToken);

        ArgumentNullException.ThrowIfNull(item);

        this._dbSet.Remove(item);
    }

    public void Update(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        this._dbSet.Update(entity);
    }

    public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await this._dbSet.AddAsync(entity, cancellationToken);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await this._context.SaveChangesAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    #endregion
}