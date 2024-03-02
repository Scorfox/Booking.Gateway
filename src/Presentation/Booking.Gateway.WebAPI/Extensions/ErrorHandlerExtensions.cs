using System.Net;
using System.Text.Json;
using MassTransit;
using Microsoft.AspNetCore.Diagnostics;
using Otus.Booking.Common.Booking.Exceptions;

namespace Booking.WebAPI.Extensions;

public static class ErrorHandlerExtensions
{
    public static void UseErrorHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                var exceptionHandlerFeature =
                    context.Features.Get<IExceptionHandlerFeature>()?.Error.GetBaseException() as RequestFaultException;

                if (exceptionHandlerFeature?.Fault == null)
                    return;

                var exception = exceptionHandlerFeature.Fault.Exceptions.FirstOrDefault()!;
                var exceptionType = exception.ExceptionType;

                context.Response.Headers.Append("Access-Control-Allow-Origin", "*");
                context.Response.ContentType = "application/json";

                if (exceptionType == typeof(NotFoundException).FullName)
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                
                if (exceptionType == typeof(BadRequestException).FullName)
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                
                if (exceptionType == typeof(OperationCanceledException).FullName)
                    context.Response.StatusCode = (int)HttpStatusCode.ServiceUnavailable;
                
                var errorResponse = new
                {
                    statusCode = context.Response.StatusCode,
                    message = exceptionHandlerFeature.Fault.Exceptions.FirstOrDefault()!.Message
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
            });
        });
    }
}