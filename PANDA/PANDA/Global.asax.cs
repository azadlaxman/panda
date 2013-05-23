// *********************************************************************************
//  Author              :   Azad Laxman.
//  Created Date        :   May 22 2013.
//  Last Modified By    :   Azad Laxman.
//  Last Modified Date  :   May 22 2013.
//  Description         :   contains code for responding to application-level events
//                          raised by ASP.NET or by HttpModules.
// *********************************************************************************

using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Panda.Config;
using Panda.WebLib;
using Panda.Services.ObjectMapper;

namespace PANDA
{
    /// <summary>
    /// Global Class for MVC HTTPApplication.
    /// <see cref="HttpApplication"/>
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Gets called on Start of Application...
        /// All application start/on start config code goes here
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(typeof(ControllerFactory));
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            //Register all the Ninject Bindings(including controllers) for DI
            //TODO: Not needed it gets initialized through static constructor.
            NinjectBindings.RegisterBindingDetails();
        }
    }
}