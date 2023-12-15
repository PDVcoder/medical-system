namespace MedicalSystem.Api.V1.Models;

public class ApiRequest<TEntity, TFilter> 
    : ApiRequestBase<TEntity> 
        where TEntity : class 
        where TFilter : class
{
    public TFilter Filter { get; set; }
}

public class ApiRequest<TFilter>
{
    public TFilter Filter { get; set; }
}
