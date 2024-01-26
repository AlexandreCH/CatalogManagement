namespace CatalogApi.Infrastructure.Exceptions;

public class ApiValidationException : Exception
{
    public ApiValidationException() : base("One or more validation errors have occurred.")
    {
        Errors = new List<string>();
    }
    public List<string>? Errors { get; }
}
