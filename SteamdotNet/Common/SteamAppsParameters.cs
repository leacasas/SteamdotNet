namespace SteamdotNet.Common
{
    /// <summary>
    /// Contains the parameters for the ISteamApps interface.
    /// It encapsulates the parameters for each method in structs.
    /// Cannot be inherited.
    /// </summary>
    public sealed class SteamAppsParameters
    {
        /// <summary>
        /// Parameters for ISteamApps.GetAppList
        /// </summary>
        public struct GetAppList
        {
            /// <summary>
            /// Key, Format and Language parameters.
            /// </summary>
            public SteamBaseParameters BaseParameters { get; private set; }

            /// <summary>
            /// Constructs the parameters for ISteamApps.GetAppList
            /// </summary>
            /// <param name="key">Steam API developer key</param>
            /// <param name="format">Output file format</param>
            /// <param name="language">ISO639-1 country code</param>
            public GetAppList(string key, OutputFileFormat format = OutputFileFormat.JSON, string language = "en") : this()
            {
                BaseParameters = new SteamBaseParameters(key, format, language);
            }
        }
        
        /// <summary>
        /// Parameters for ISteamApps.GetServersAtAddress
        /// </summary>
        public struct GetServersAtAddress
        {
            /// <summary>
            /// Key, Format and Language parameters.
            /// </summary>
            public SteamBaseParameters BaseParameters { get; private set; }

            /// <summary>
            /// IP address of the server (IPv4 format)
            /// </summary>
            public string Addr { get; set; }

            /// <summary>
            /// Constructs the parameters for ISteamApps.GetServersAtAddress
            /// </summary>
            /// <param name="addr">IP address of the server (IPv4 format)</param>
            /// <param name="key">Steam API developer key</param>
            /// <param name="format">Output file format</param>
            /// <param name="language">ISO639-1 country code</param>
            public GetServersAtAddress(string addr, string key, OutputFileFormat format = OutputFileFormat.JSON, string language = "en") : this()
            {
                Addr = addr;
                BaseParameters = new SteamBaseParameters(key, format, language);
            }
        }

        /// <summary>
        /// Parameters for ISteamApps.UpToDateCheck
        /// </summary>
        public struct UpToDateCheck
        {
            /// <summary>
            /// Key, Format and Language parameters.
            /// </summary>
            public SteamBaseParameters BaseParameters { get; private set; }

            /// <summary>
            /// AppID of game. For example, Team Fortress 2 is 440.
            /// </summary>
            public uint AppId { get; set; }

            /// <summary>
            /// Installed version of the game.
            /// </summary>
            public uint Version { get; set; }

            /// <summary>
            /// Creates the parameters for ISteamApps.UpToDateCheck
            /// </summary>
            /// <param name="appid"></param>
            /// <param name="version"></param>
            /// <param name="key">Steam API developer key</param>
            /// <param name="format">Output file format</param>
            /// <param name="language">ISO639-1 country code</param>
            public UpToDateCheck(uint appid, uint version, string key, OutputFileFormat format = OutputFileFormat.JSON, string language = "en") : this()
            {
                AppId = appid;
                Version = version;
                BaseParameters = new SteamBaseParameters(key, format, language);
            }
        }
    }
}