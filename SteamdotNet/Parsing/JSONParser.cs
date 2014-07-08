using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

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

        /// <summary>
        /// Serializes a given object into a JSON string.
        /// </summary>
        /// <param name="source">Object to serialize</param>
        /// <typeparam name="T">Object type</typeparam>
        /// <returns>JSON String</returns>
        public string SerializeFromObject<T>(T source)
        {
            return JsonConvert.SerializeObject(source);
        }

        /// <summary>
        /// Deserializes a given JSON string into an object
        /// </summary>
        /// <param name="source">JSON string</param>
        /// <typeparam name="T">Object type</typeparam>
        /// <returns>Deserialized object</returns>
        public T DeserializeToObject<T>(string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }
    }
}