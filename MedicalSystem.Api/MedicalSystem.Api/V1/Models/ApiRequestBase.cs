namespace MedicalSystem.Api.V1.Models;

public class ApiRequestBase<TEntity> where TEntity : class
{
    public TEntity Entity { get; set; }
}
