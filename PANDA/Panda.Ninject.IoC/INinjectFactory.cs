using System;
using System.Collections.Concurrent;
using System.Xml.Linq;

namespace Panda.Ninject.IoC
{
    //  Summary:
    //      Factory Wrapper Interface for managing (Ninject)Dependency Injections
    public interface INinjectFactory
    {
        /// <summary>
        /// Adds Bindings from Interface dictionary mappings.
        /// </summary>
        void AddBindings(ConcurrentDictionary<Type, Type> bindings);

        /// <summary>
        /// Resolves All dependencies for requested instance and returns that instance
        /// </summary>
        /// <typeparam name="T">Requested Implementation type</typeparam>
        /// <returns>Instance of Implementation type</returns>
        T Resolve<T>();

        /// <summary>
        /// Resolves property injection dependencies in already instantiated Implementation types
        /// </summary>
        /// <param name="obj">Specified instance of implementation type</param>
        void Inject(object obj);

        /// <summary>
        /// Checks if specified module is loaded or not.
        /// </summary>
        /// <param name="name">name of the module.</param>
        /// <returns>True if the specified module has been loaded; otherwise, false.</returns>
        bool HasModule(string name);

        /// <summary>
        /// Adds Bindings of interfaces based on input xml files path.
        /// </summary>
        /// <param name="xmlFilePath">components config Xml file path containing component mappings.</param>
        void AddBindings(string xmlFilePath);

        /// <summary>
        /// Adds Bindings of interfaces based on input xml Document.
        /// </summary>
        /// <param name="xmlFile">XmlDoc components config containing, Component mappings.</param>
        void AddBindings(XDocument xmlFile);
    }
}