using Microsoft.AspNetCore.Routing;

namespace STEPsaver.Website
{
    public static class RouteDataExtensions
    {
        public static bool IsAction(this RouteData routeData, string action, string controller)
        {
            string currentController = routeData.Values["Controller"]?.ToString() ?? string.Empty;
            string currentAction = routeData.Values["Action"]?.ToString() ?? string.Empty;

            return currentController.Equals(controller)
                && currentAction.Equals(action);
        }
    }
}
