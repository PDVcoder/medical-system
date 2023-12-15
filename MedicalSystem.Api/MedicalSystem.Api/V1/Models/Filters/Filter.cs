using MedicalSystem.Model.Enums;

namespace MedicalSystem.Api.V1.Models.Filters;

public class Filter
{
    public string Field { get; set; }

    public FilterOption Option { get; set; }

    public string Value { get; set; }
}
