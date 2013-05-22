// ***************************************************************************
//  Author              :   Azad Laxman.
//  Created Date        :   May 22 2013.
//  Last Modified By    :   Azad Laxman.
//  Last Modified Date  :   May 22 2013.
//  Description         :   Ninject DI framework wrapper (Factory).
// ***************************************************************************

using System;
using System.Collections.Concurrent;
using System.Xml.Linq;
using Ninject;

namespace Panda.Ninject.IoC
{
    //  Summary:
    //      Factory Wrapper implementation for managing (Ninject)Dependency Injections
    public static class NinjectFactory
    {
        #region MEMBER_VARIABLES
        //  Summary:
        //      Ninject Standard kernel instance
        private static volatile IKernel _kernel = new StandardKernel();

        //  Summary
        //      Locker for singleton      
        private static object _syncRoot = new object();

        public static IKernel NinjectKernel {
            get { return NinjectFactory._kernel; }
            private set { _kernel = value; }
        }
        #endregion

        #region MEMBER_METHODS
        ///<summary>
        /// To get instance of (Singleton)NinjectFactory
        ///</summary>
        /// <returns>Singleton Instance of Ninject Factory.</returns>
        public static T GetInstance<T>()
        {
            return _kernel.TryGet<T>();;
        }

        ///<summary>
        /// To get IoC concrete component. 
        ///</summary>
        /// <returns>Concrete Implementation.</returns>
        public static object GetInstance(Type componentType)
        {
            return _kernel.TryGet(componentType);
        }

        ///<summary>
        /// Maps DI Contracts to its bindings.
        /// </summary>
        ///<param name="bindings">Dictionary containing mapppings for Key:Interface Value:Implementation.</param>
        public static void AddBindings(ConcurrentDictionary<Type, Type> bindings)
        {
            lock (_syncRoot)
            {
                foreach (var binding in bindings)
                {
                    Type IType = binding.Key;
                    Type ImplementationType = binding.Value;
                    _kernel.Bind(IType).To(ImplementationType);
                }
            }
        }

        /// <summary>
        /// Adds Bindings of interfaces based on input xml files path.
        /// </summary>
        /// <param name="xmlFilePath">components config Xml file path containing component mappings.</param>
        public static void AddBindings(string xmlFilePath)
        {
            throw new NotImplementedException();

            XDocument componentsConfigXml = XDocument.Load(xmlFilePath);
            try
            {
            }
            catch (System.Exception ex)
            {
                throw new Exception("NinjectFactory.AddBindings():Error while loading Ninject components config, Path"+xmlFilePath);
            }
        }

        /// <summary>
        /// Adds Bindings of interfaces based on input xml Document.
        /// </summary>
        /// <param name="xmlFile">XmlDoc components config containing, Component mappings.</param>
        public static void AddBindings(XDocument xmlFile)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (System.Exception ex)
            {
                throw new Exception("NinjectFactory.AddBindings():Error while loading Ninject Xml bindings.");
            }
        }

        /// <summary>
        /// Resolves All dependencies for requested instance and returns that instance.
        /// </summary>
        /// <typeparam name="componentType">Requested Implementation type.</typeparam>
        /// <returns>Instance of Implementation type.</returns>
        public static object Resolve(Type componentType)
        {
            return _kernel.Get(componentType);
        }

        /// <summary>
        /// Resolves All dependencies for requested instance and returns that instance.
        /// </summary>
        /// <typeparam name="T">Requested Implementation type.</typeparam>
        /// <returns>Instance of Implementation type.</returns>
        public static T Resolve<T>()
        {
            return _kernel.TryGet<T>();
        }

        /// <summary>
        /// Checks if specified module is loaded or not.
        /// </summary>
        /// <param name="name">name of the module.</param>
        /// <returns>True if the specified module has been loaded; otherwise, false.</returns>
        public static bool HasModule(string name)
        {
            return _kernel.HasModule(name);
        }

        /// <summary>
        /// Checks if specified module is loaded or not.
        /// </summary>
        /// <param name="componentType">Inteface Type of component to fetch service.</param>
        /// <returns>True if the specified module has been loaded; otherwise, false.</returns>
        public static bool HasModule(Type componentType)
        {
            return ((null == _kernel.GetBindings(componentType))?false:true);
        }

        /// <summary>
        /// Resolves property injection dependencies in already instantiated Implementation types.
        /// </summary>
        /// <param name="obj">Specified instance of implementation type.</param>
        public static void Inject(object obj)
        {
            _kernel.Inject(obj);
        }
        #endregion
    }
}
