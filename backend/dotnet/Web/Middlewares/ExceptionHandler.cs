using System.Text;
using System.Text.Json;
using Web.Contracts;

namespace Web.Middlewares;

/// <summary>
/// Middleware для глобального перехвата ошибок
/// </summary>
public class ExceptionHandler
{
    private readonly RequestDelegate _next;

    /// <summary>
    /// Middleware для глобального перехвата ошибок
    /// </summary>
    public ExceptionHandler(RequestDelegate next)
    {
        _next = next;
    }

    /// <summary>
    /// Выполнение кода middleware
    /// </summary>
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            var content = JsonSerializer.Serialize(
                new ExceptionContract("Внутренняя ошибка", e.Message), //TODO Временное решение. В будущем вынести сообщение в лог, а наверх выдавать "Произошла ошибка"
                new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                });
            
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(content, Encoding.UTF8);

        }
    }
}

/// <summary>
/// Расширения для мидлвара по отлову исключений
/// </summary>
public static class ExceptionHandlerMiddlewareExtensions
{
    /// <summary>
    /// Включить обработку исключений
    /// </summary>
    public static IApplicationBuilder UseExceptionsHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionHandler>();
    }
}
