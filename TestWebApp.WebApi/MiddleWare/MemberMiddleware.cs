using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using TestWebApp.WebApi.Model;

namespace TestWebApp.WebApi.MiddleWare
{
    public class MemberMiddleware
    {

        private RequestDelegate _next;

        private Member _options;


        public MemberMiddleware(RequestDelegate next, IOptions<Member> options)
        {
            _next = next;
            _options = options.Value;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Path == "/member") 
            {
                await context.Response.WriteAsync($"{_options.MemberName}, {_options.MemberGroup}");
            }
            else
            {
                await _next(context);
            }
        }
    }
}
