// ***************************************************************************
//  Author              :   Azad Laxman.
//  Created Date        :   May 22 2013.
//  Last Modified By    :   Azad Laxman.
//  Last Modified Date  :   May 22 2013.
//  Description         :   Controller Instances management related code.
// ***************************************************************************

using System;
using System.Web.Mvc;
using Panda.Ninject.IoC;

namespace Panda.WebLib
{
    /// <summary>
    /// Inherited Implementation of Default Controller Factory.
    /// <remarks>Get Controller instances overridden to use DI using Ninject.</remarks>
    /// <see cref="DefaultControllerFactory"/>
    /// </summary>
    public class ControllerFactory :DefaultControllerFactory
    {
        /// <summary>
        /// Fetch an instance of the specific controller type.
        /// </summary>
        /// <param name="requestContext">Current Execution context.</param>
        /// <param name="controllerType">Type of the controller instance requested.</param>
        /// <returns>An instance of requested controller type.</returns>
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return (controllerType != null && NinjectFactory.HasModule(controllerType)) ?
                NinjectFactory.GetInstance(controllerType) as IController : base.GetControllerInstance(requestContext, controllerType);
        }
    }
}
