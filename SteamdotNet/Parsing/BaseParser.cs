using System;

namespace SteamdotNet.Parsing
{
    /// <summary>
    /// Holds all the base methods for all parsers.
    /// </summary>
    public class BaseParser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual T ParseFromURL<T>(string url) where T : new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual string SerializeFromObject<T>(T source)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual T DeserializeToObject<T>(string source)
        {
            throw new NotImplementedException();
        }
    }
}