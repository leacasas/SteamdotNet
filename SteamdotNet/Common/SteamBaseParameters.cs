using SteamdotNet.Exceptions;

namespace SteamdotNet.Common
{
    /// <summary>
    /// This class encapsulates three parameters that are shared
    /// across all methods of all interfaces of the Steam Web API.
    /// </summary>
    public struct SteamBaseParameters
    {
        /// <summary>
        /// Steam Developer Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Output file format. JSON, XML or Valve Data Format
        /// </summary>
        public OutputFileFormat Format { get; set; }

        /// <summary>
        /// Output language. ISO 639-1 code format.
        /// </summary>
        public OutputLanguage Language { get; set; }

        /// <summary>
        /// Construct the common parameters.
        /// </summary>
        /// <param name="key">Steam API developer key</param>
        /// <param name="format">Output file format</param>
        /// <param name="language">ISO 639-1 language code</param>
        /// <exception cref="InvalidDeveloperKeyException">The provided Steam Developer key is invalid</exception>
        public SteamBaseParameters(string key, OutputFileFormat format = OutputFileFormat.JSON, OutputLanguage language = OutputLanguage.EN) : this()
        {
            if(string.IsNullOrEmpty(key)|string.IsNullOrWhiteSpace(key))
                throw new InvalidDeveloperKeyException();
            Key = key;
            Format = format;
            Language = language;
        }
    }
}