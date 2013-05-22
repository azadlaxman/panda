// *********************************************************************************
//  Author              :   Azad Laxman.
//  Created Date        :   May 22 2013.
//  Last Modified By    :   Azad Laxman.
//  Last Modified Date  :   May 22 2013.
//  Description         :   Application Runtime global Configuration related code.
// *********************************************************************************
using Panda.Ninject.IoC;
using PANDA.Controllers;

namespace Panda.Config
{
    /// <summary>
    /// Helper class to bind the Types and its concrete implementations. 
    /// </summary>
    public static class NinjectBindings
    {
        /// <summary>
        /// API to register/map all the DI related bindings across entire application.
        /// </summary>
        public static void RegisterBindingDetails()
        {
            #region Controller_Binding_Mappings
            //dictBindings.TryAdd(typeof(IController),typeof(HomeController));
            NinjectFactory.NinjectKernel.Bind<HomeController>().ToSelf();
            NinjectFactory.NinjectKernel.Bind<AccountController>().ToSelf();
            #endregion
        }
    }
}
