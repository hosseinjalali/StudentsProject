using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using StudentBLL.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentDAL.CustomExceptionMiddleware
{
   public class ExeptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExeptionMiddleware(RequestDelegate next,ILogger logger)
        {
            this._next = next;
            this._logger = logger;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch(Exception ex)
            {
                _logger.LogError($"something were wrong :{ex}");
                await HandleExceptionAsync(httpContext);
            }
        }
        private Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.ContentType = "Application//json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Massage = "Internal Server Error From Custom Middleware"

            }.ToString());
        }
    }
}
