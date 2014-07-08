using SteamdotNet.Common;
using System.Linq;
using System.Text;

namespace SteamdotNet
{
    /// <summary>
    /// Factory pattern. All object are created through this class.
    /// </summary>
    public sealed class SteamdotNetFactory
    {
        /// <summary>
        /// Construct a valid call to the given API method providing the base URL and
        /// all the optional and required parameters.
        /// </summary>
        /// <param name="baseURL">Public URL of the API Method</param>
        /// <param name="baseParameters">Key, Format and language parameters</param>
        /// <param name="parameters">Method-specific parameters, they are contained in a struct</param>
        /// <typeparam name="T">struct</typeparam>
        /// <returns>Valid URL ready to call the API method</returns>
        public static string CreateMethodUrl<T>(string baseURL, SteamBaseParameters baseParameters, T parameters) where T : struct
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.AppendFormat("{0}?key={1}&format={2}&language={3}", baseURL, baseParameters.Key, baseParameters.Format, baseParameters.Language);
            foreach (var propertyInfo in parameters.GetType().GetProperties().Where(propertyInfo => propertyInfo.PropertyType != typeof(SteamBaseParameters)))
            {
                urlBuilder.AppendFormat("&{0}={1}", propertyInfo.Name, propertyInfo.GetValue(parameters, null));
            }
            return urlBuilder.ToString();
        }
    }
}