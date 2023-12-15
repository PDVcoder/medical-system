using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace MedicalSystem.Model.Data.Repositories;

public interface IRepository<T> where T : class
{
    /// <summary>
    /// Gets the asynchronous.
    /// </summary>
    /// <param name="id">Id of T</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// T entity
    /// </returns>
    Task<T> GetAsync(Guid? id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets all asynchronous.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// Collection of T
    /// </returns>
    Task<ICollection<T>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the asynchronous.
    /// </summary>
    /// <param name="id">id of T</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">Entity with current id does not exist</exception>
    Task DeleteAsync(Guid? id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the specified entity.
    /// </summary>
    /// <param name="entity">T entity</param>
    /// <exception cref="ArgumentNullException">T entity does not exist</exception>
    void Update(T entity);

    /// <summary>
    /// Creates the asynchronous.
    /// </summary>
    /// <param name="entity">T entity</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">T entity is null</exception>
    Task CreateAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Finds the asynchronous.
    /// </summary>
    /// <param name="expression">Lambda exprretion, predicate</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// Collection of T
    /// </returns>
    Task<ICollection<T>> FindAsync(Expression<Func<T, Boolean>> expression, CancellationToken cancellationToken = default);

    /// <summary>
    /// Saves the changes asynchronous.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns></returns>
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
