using System.Net;

namespace MedicalSystem.Api.V1.Models;

public class ApiResponseBase
{
    public HttpStatusCode HttpStatusCode { get; set; }

    public bool IsSuccessful { get; set; }

    public string ErrorMessage { get; set; }
}
