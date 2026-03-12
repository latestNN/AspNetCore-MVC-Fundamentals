
namespace P07_Route_Yapilanmasi.Constraints
{
    public class CustomConstrains : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var idValue = values[routeKey]; //id değeri alınır.
            return true;
        }
    }
}
