using System.Net;

namespace SteamdotNet.Parsing.JSON
{
    /// <summary>
    /// First rudimentary implementation of a JSON parser, reading a JSON file from a REST service.
    /// </summary>
    public class JSONParser
    {
        /// <summary>
        /// Reads the JSON returned from a service URL. The JSON is parsed into a dynamic object.
        /// </summary>
        /// <returns>Details of the JSON object.</returns>
        public string ReadJSONfromURL()
        {
            const string url = "http://ip.jsontest.com/";
            using (var webClient = new WebClient())
            {
                var jsonObj = webClient.DownloadString(url);
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonObj);
                return (string) result.ip;
            }
        }
    }
}