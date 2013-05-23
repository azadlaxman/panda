// ***************************************************************************
//  Author              :   Azad Laxman.
//  Created Date        :   May 23 2013.
//  Last Modified By    :   Azad Laxman.
//  Last Modified Date  :   May 23 2013.
//  Description         :   Containes Generic code for route mappings.
// ***************************************************************************

using System;
using AutoMapper;

namespace Panda.Services.ObjectMapper
{
    /// <summary>
    /// ObjectMapper Static Class to Initialize Object mappings.
    /// <remarks>Has to be initialized at Application level.</remarks>
    /// </summary>
    public class ObjectMapper
    {
        /// <summary>
        /// Static constroctor to intialize all mappings.
        /// </summary>
        static ObjectMapper()
        {
            MapObjects();
        }

        /// <summary>
        /// Application level Data objects custom mappings from Source Types to Destination Types.
        /// </summary>
        private static void MapObjects()
        {
            //TODO:Insert all DataObjects mappings here

        }

        /// <summary>
        /// Map from source type object to Destination
        /// </summary>
        /// <typeparam name="TSource">Type Of Source Object.</typeparam>
        /// <typeparam name="TDestination">Type Of Destination Object.</typeparam>
        /// <param name="source">Source instance to be copied.</param>
        /// <param name="destination">Destination instance to be copied.</param>
        /// <returns>Copied destination object.</returns>
        public static TDestination MapObjects<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }

        /// <summary>
        /// Create object of type IDestination from source type.
        /// </summary>
        /// <typeparam name="TSource">Type Of Source Object.</typeparam>
        /// <typeparam name="TDestination">Type Of Destination Object.</typeparam>
        /// <param name="source">Source instance to be copied.</param>
        /// <returns>Copied destination object.</returns>
        public static TDestination MapObjects<TSource, TDestination>(TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        /// <summary>
        /// Create object of type destinationType from source type.
        /// </summary>
        /// <param name="source">Source object to be copied.</param>
        /// <param name="sourceType">Type of Source Object.</param>
        /// <param name="destinationType">Type of Destination Object.</param>
        /// <returns>Copied Destination Object.</returns>
        public static object MapObjects(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }
    }
}
