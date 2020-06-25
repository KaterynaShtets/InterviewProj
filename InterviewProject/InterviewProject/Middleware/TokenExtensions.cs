using Microsoft.AspNetCore.Builder;

namespace InterviewProject.Middleware
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseRequestHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestHandlerMiddleware>();
        }
    }
}
