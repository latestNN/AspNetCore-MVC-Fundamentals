using P09._01_Custom_Middleware.Middlewares;
using System.Runtime.CompilerServices;

namespace P09._01_Custom_Middleware.Extentions
{
    static  class Extention
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
