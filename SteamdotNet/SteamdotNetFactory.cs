using SteamdotNet.Common;

namespace SteamdotNet
{
    /// <summary>
    /// Factory pattern. All object are created through this class.
    /// </summary>
    public sealed class SteamdotNetFactory
    {
        /// <summary>
        /// Factory method. It creates a SteamBaseParameters object with its values
        /// read from the configuration.
        /// </summary>
        /// <returns>SteamBaseParameters object</returns>
        public static SteamBaseParameters CreateBaseParameters()
        {
            return new SteamBaseParameters(string.Empty, OutputFileFormat.JSON, string.Empty);
        }

        /// <summary>
        /// Generates the URL for a method call, using a base URL and
        /// an object containing all the parameters
        /// </summary>
        /// <param name="baseURL">The base URL of the method.</param>
        /// <param name="parameters">All the required and optional parameters</param>
        /// <typeparam name="T">struct</typeparam>
        /// <returns>Complete URL to perform a method call</returns>
        public static string CreateMethodUrl<T>(string baseURL, T parameters) where T : struct
        {
            return string.Empty;
        }
    }
}