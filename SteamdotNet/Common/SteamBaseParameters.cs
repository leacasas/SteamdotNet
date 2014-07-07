namespace SteamdotNet.Common
{
    /// <summary>
    /// 
    /// </summary>
    public struct SteamBaseParameters
    {
        /// <summary>
        /// 
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public OutputFileFormat Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Language { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="format"></param>
        /// <param name="language"></param>
        public SteamBaseParameters(string key, OutputFileFormat format, string language) : this()
        {
            Key = key;
            Format = format;
            Language = language;
        }
    }
}