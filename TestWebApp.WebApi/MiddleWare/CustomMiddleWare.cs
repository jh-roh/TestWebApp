using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace TestWebApp.WebApi.MiddleWare
{
    public class CustomMiddleWare
    {
        private RequestDelegate _next;

        public CustomMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Method == HttpMethods.Get && context.Request.Query["mdw"] == "test")
            {
                if(!context.Response.HasStarted)
                {
                    context.Response.ContentType = "text/plain";
                }

                await context.Response.WriteAsync("Custom Middleware is working");
            }

            // Do something with context near the beginning of request processing.
            await _next(context);
            // Clean up.
        }

    }
}
