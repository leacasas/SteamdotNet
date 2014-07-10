using System.IO;
using System.Net.Http;
using System.Xml.Serialization;

namespace SteamdotNet.Parsing
{
    /// <summary>
    /// XML Parser
    /// </summary>
    public sealed class XMLParser : BaseParser
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
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}