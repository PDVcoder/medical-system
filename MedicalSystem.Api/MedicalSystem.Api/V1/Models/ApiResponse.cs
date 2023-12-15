using System.Net;

namespace MedicalSystem.Api.V1.Models;

public class ApiResponse<TEntity> : ApiResponseBase
    where TEntity : class
{
    public TEntity Entity { get; set; }
}
