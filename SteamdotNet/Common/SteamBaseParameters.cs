namespace SteamdotNet.Common
{
    /// <summary>
    /// This struct contains the three common parameters that can be used
    /// in all of the methods of all interfaces of the Steam Web API.
    /// </summary>
    public struct SteamBaseParameters
    {
        internal string Key { get; set; }
        internal OutputFileFormat Format { get; set; }
        internal string Language { get; set; }

        internal SteamBaseParameters(string key, OutputFileFormat format, string language) : this()
        {
            Key = key;
            Format = format;
            Language = language;
        }
    }
}