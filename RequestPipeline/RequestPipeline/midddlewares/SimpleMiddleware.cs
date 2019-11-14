using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestPipeline.midddlewares
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        public SimpleMiddleware(RequestDelegate next) {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync(text: "<div>Hello World from the middleware 3</div>");
            await _next(context);
            await context.Response.WriteAsync(text: "<div>Returning from the middleware 3</div>");
        }

    }
}
