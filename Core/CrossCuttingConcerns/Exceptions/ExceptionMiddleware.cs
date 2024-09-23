using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;   

        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request."); // Loglama
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status400BadRequest;

                if (exception is BusinessException)
                {
                    ProblemDetails problemDetails = new ProblemDetails
                    {
                      Title = "Business Rule Violation",
                      Detail = exception.Message,
                      Type = "BusinessException",
                      Status = StatusCodes.Status400BadRequest,
                    };
                   
                    await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
                }else if(exception is ValidationException)
                {
                    ValidationException validationException = (ValidationException)exception;
                    ValidationProblemDetails validationProblemDetails = new ValidationProblemDetails(validationException.Errors.ToList());

                    await context.Response.WriteAsync(JsonSerializer.Serialize<ValidationProblemDetails>(validationProblemDetails));
                }
                else if(exception is AuthorizationException)
                {
                    ProblemDetails problemDetails = new ProblemDetails
                    {
                        Title = "Authorization Role Violation",
                        Detail = exception.Message,
                        Type = "Authorization",
                        Status = StatusCodes.Status403Forbidden,
                    };
                
                  
                    
                    await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
                }
                else
                {

                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError; // 500 Hatası döndür

                    var problemDetails = new ProblemDetails
                    {
                        Title = "Internal Server Error",
                        Detail = exception.Message,
                        Type = "UnknownError",
                        Status = StatusCodes.Status500InternalServerError,
                    };

                    // Inner exception'ı ekleyin
                    if (exception.InnerException != null)
                    {
                        problemDetails.Detail += $" Inner Exception: {exception.InnerException.Message}";
                    }

                    await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
                }
            }
        }
    }
}
