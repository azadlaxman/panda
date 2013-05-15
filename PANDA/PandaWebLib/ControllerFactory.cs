using System;
using System.Web.Mvc;
using Panda.Ninject.IoC;

namespace Panda.WebLib
{
    public class ControllerFactory :DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            var ninjectFactory = NinjectFactory.GetInstance();
            return (controllerType != null && ninjectFactory.HasModule(controllerType)) ?
                ninjectFactory.Resolve(controllerType) as IController : base.GetControllerInstance(requestContext, controllerType);
        }
    }
}
