using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WorkoutApplication
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            Console.WriteLine($"➡️  Handling request: {context.Request.Method} {context.Request.Path}");

            await _next(context); // Call the next middleware in the pipeline

            stopwatch.Stop();
            Console.WriteLine($"⬅️  Finished {context.Response.StatusCode} in {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}