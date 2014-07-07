using System.Net;

namespace SteamdotNet.Parsing
{
    /// <summary>
    /// First rudimentary implementation of a JSON parser, reading a JSON file from a REST service.
    /// </summary>
    public sealed class JSONParser : BaseParser
    {
        /// <summary>
        /// Parses a JSON from a service call to a given object type.
        /// </summary>
        /// <param name="url">URL of the service to call</param>
        /// <typeparam name="T">Type of object to return</typeparam>
        /// <returns>Parsed object of T type</returns>
        public override T ParseFromURL<T>(string url)
        {
            using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString(url);
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                return (T)result;
            }
        }
    }
}