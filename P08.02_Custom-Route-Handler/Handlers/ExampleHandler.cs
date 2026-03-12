namespace P08._02_Custom_Route_Handler.Handlers
{
    public class ExampleHandler
    {
        public RequestDelegate Handler() 
        { 
            return async c =>
            {
                await c.Response.WriteAsync("Hello from the custom route handler!");
            };      
        }
    }
}
