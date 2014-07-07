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
            public SteamBaseParameters BaseParameters
            {
                get { return SteamdotNetFactory.CreateBaseParameters(); }
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
            public SteamBaseParameters BaseParameters
            {
                get { return SteamdotNetFactory.CreateBaseParameters(); }
            }

            /// <summary>
            /// IP address of the server (IPv4 format)
            /// </summary>
            public string Addr { get; set; }

            /// <summary>
            /// Constructs the parameters for ISteamApps.GetServersAtAddress
            /// </summary>
            /// <param name="addr">IP address of the server (IPv4 format)</param>
            public GetServersAtAddress(string addr) : this()
            {
                Addr = addr;
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
            public SteamBaseParameters BaseParameters
            {
                get { return SteamdotNetFactory.CreateBaseParameters(); }
            }

            /// <summary>
            /// AppID of game. For example, Team Fortress 2 is 440.
            /// </summary>
            public uint AppId { get; set; }

            /// <summary>
            /// Installed version of the game.
            /// </summary>
            public uint Version { get; set; }

            /// <summary>
            /// Construct the parameters for ISteamApps.UpToDateCheck
            /// </summary>
            /// <param name="appid">AppID of game. For example, Team Fortress 2 is 440.</param>
            /// <param name="version">Installed version of the game.</param>
            public UpToDateCheck(uint appid, uint version) : this()
            {
                AppId = appid;
                Version = version;
            }
        }
    }
}