using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Middleware
{
    public class RequestHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<RequestHandlerMiddleware> logger;

        public RequestHandlerMiddleware(RequestDelegate next, ILogger<RequestHandlerMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var method = context.Request.Method;
            logger.LogInformation($"Processing request {method} interview");
            await next.Invoke(context);
            var responseCode = context.Response.StatusCode;
            if(responseCode == 200)
            {
                logger.LogInformation($"request {method} was successfully handled");
            }
            else
            {
                logger.LogInformation($"request {method} was not handled");
            }
        }
    }
}
