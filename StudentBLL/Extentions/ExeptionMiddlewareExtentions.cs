using Microsoft.AspNetCore.Builder;
using StudentDAL.CustomExceptionMiddleware;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Extentions
{
    public static class ExeptionMiddlewareExtentions
    {
        public static void ConfigCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExeptionMiddleware>();
        }
    }
}
