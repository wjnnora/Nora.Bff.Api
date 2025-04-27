using Nora.Core.Domain.Exceptions;
using Refit;
using System.Net;
using System.Text.Json;

namespace Nora.Bff.Api.Middlewares;

public class ExceptionMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (ApiException ex)
        {
            await HandleRequestExceptionAsync(httpContext, ex);
        }
        catch (DomainException ex)
        {
            var message = JsonSerializer.Serialize(new[] { ex.Message });
            await HandleRequestExceptionAsync(httpContext, message, HttpStatusCode.BadRequest);
        }
        catch (Exception ex)
        {
            var message = JsonSerializer.Serialize(new[] { ex.Message });
            await HandleRequestExceptionAsync(httpContext, message, HttpStatusCode.InternalServerError);
        }
    }

    private static async Task HandleRequestExceptionAsync(HttpContext context, string message, HttpStatusCode statusCode)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;
        await context.Response.WriteAsync(message);
    }

    private static async Task HandleRequestExceptionAsync(HttpContext context, ApiException exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)exception.StatusCode;

        if (exception.StatusCode == HttpStatusCode.NoContent) return;

        await SetResponseAsync(context, exception);
    }

    private static async Task SetResponseAsync(HttpContext context, ApiException exception)
    {
        var message = await GetMessageAsync(exception);
        await context.Response.WriteAsync(message);
    }

    private static async Task<string> GetMessageAsync(ApiException exception)
    {
        var message = !string.IsNullOrEmpty(exception.Content)
            ? await exception.GetContentAsAsync<dynamic>()
            : exception.Message;

        return JsonSerializer.Serialize(message);
    }
}