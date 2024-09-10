using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
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

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception exception)
            {
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
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    await context.Response.WriteAsync("Bilinmedik Hata");
                }
            }
        }
    }
}
