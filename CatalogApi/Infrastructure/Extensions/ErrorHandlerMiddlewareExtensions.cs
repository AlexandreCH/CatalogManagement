namespace CatalogApi.Infrastructure.Extensions;

// Extension method used to add the middleware to the HTTP request pipeline.
public static class ErrorHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseErrorHandlerMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ErrorHandlerMiddleware>();
    }
}
