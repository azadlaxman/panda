using System.Web.Mvc;
using System.Web.Routing;

namespace System.Web.Routing
{
    public static class RoutingHelper
    {
        public static RouteBase MapPandaRoute(this RouteCollection routes, string name, string url, object defaults)
        {
            return MapPandaRoute(routes, name, url, defaults, new { });
        }

        public static RouteBase MapPandaRoute(this RouteCollection routes, string name, string url, object defaults, object constraints)
        {
            routes.MapRoute(string.Format("ctx_m_{0}", name), string.Format("{0}/{1}/{2}", "ctx{context}", "m_{menu}", url), defaults, constraints);
            routes.MapRoute(string.Format("ctx_{0}", name), string.Format("{0}/{1}", "ctx{context}", url), defaults, constraints);
            routes.MapRoute(string.Format("m_{0}", name), string.Format("{0}/{1}", "m_{menu}", url), defaults, constraints);

            return routes.MapRoute(name, url, defaults, constraints);
        }
    }
}

namespace System.Web.Mvc
{
    public static class RoutingHelper
    {
        public static RouteBase MapPandaRoute(this AreaRegistrationContext context, string name, string url, object defaults)
        {
            return MapPandaRoute(context, name, url, defaults, new { });
        }

        public static RouteBase MapPandaRoute(this AreaRegistrationContext context, string name, string url, object defaults, object constraints)
        {
            context.MapRoute(string.Format("ctx_m_{0}", name), string.Format("{0}/{1}/{2}", "ctx{context}", "m_{menu}", url), defaults, constraints);
            context.MapRoute(string.Format("ctx_{0}", name), string.Format("{0}/{1}", "ctx{context}", url), defaults, constraints);
            context.MapRoute(string.Format("m_{0}", name), string.Format("{0}/{1}", "m_{menu}", url), defaults, constraints);

            return context.MapRoute(name, url, defaults, constraints);
        }
    }
}
