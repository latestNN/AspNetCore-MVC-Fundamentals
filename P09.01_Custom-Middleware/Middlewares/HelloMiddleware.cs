namespace P09._01_Custom_Middleware.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            // Custom Operasonyon...

            Console.WriteLine("Selamin Aleykumm"); // Middleware'in çalıştıği zaman bu mesajı görünecek.
            await _next.Invoke(httpContext); // Bir sonraki Middleware'e gider. İlgili Middleware'lerin işi bitince buradan devam eder.
            Console.WriteLine("Aleykum Selam"); // Diğer Middleware'lerden gelince buradan devam eder.
        }
    }
}
