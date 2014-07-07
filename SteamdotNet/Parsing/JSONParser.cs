using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace SteamdotNet.Parsing
{
    /// <summary>
    /// First rudimentary implementation of a JSON parser, reading a JSON file from a REST service.
    /// </summary>
    public sealed class JSONParser : BaseParser
    {
        /// <summary>
        /// Parses a JSON from a service call to a given object type.
        /// It deserializes directly to a stream to reduce memory usage.
        /// </summary>
        /// <param name="url">URL of the service to call</param>
        /// <typeparam name="T">Type of object to return</typeparam>
        /// <returns>Parsed object of T type</returns>
        public override T ParseFromURL<T>(string url)
        {
            using (var client = new HttpClient())
            using (Stream stream = client.GetStreamAsync(url).Result)
            using (var reader = new StreamReader(stream))
            using (JsonReader jsonReader = new JsonTextReader(reader))
            {
                return new JsonSerializer().Deserialize<T>(jsonReader);
            }
        }
    }
}