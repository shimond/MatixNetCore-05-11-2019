using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace webApiEx.mw
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MatrixMiddleware
    {
        private readonly RequestDelegate _next;

        public MatrixMiddleware(RequestDelegate next)
        {
            Console.Read();
            _next = next;
        }
        
        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MatrixMiddlewareExtensions
    {
        public static IApplicationBuilder UseMatrixMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MatrixMiddleware>();
        }
    }
}
