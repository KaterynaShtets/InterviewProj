using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace InterviewProject.Middleware
{
    public class RequestHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestHandlerMiddleware> _logger;

        public RequestHandlerMiddleware(RequestDelegate next, ILogger<RequestHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var method = context.Request.Method;
            _logger.LogInformation($"Processing request {method} interview"); 
            await _next.Invoke(context);
            var responseCode = context.Response.StatusCode;
            _logger.LogInformation(responseCode == 200
                ? $"request {method} was successfully handled"
                : $"request {method} was not handled");
        }
    }
}
