namespace SteamdotNet.Common
{
    /// <summary>
    /// Contains the parameters for the ISteamApps interface.
    /// It encapsulates the parameters for each method in structs.
    /// </summary>
    internal sealed class SteamAppsParameters
    {
        /// <summary>
        /// Parameters for SteamAppsParameters.GetAppList
        /// </summary>
        internal struct GetAppList
        {
            internal SteamBaseParameters BaseParameters
            {
                get { return SteamdotNetFactory.CreateBaseParameters(); }
            }
        }

        /// <summary>
        /// Parameters for SteamAppsParameters.GetServersAtAdress
        /// </summary>
        internal struct GetServersAtAdress
        {
            internal SteamBaseParameters BaseParameters
            {
                get { return SteamdotNetFactory.CreateBaseParameters(); }
            }

            internal string Addr { get; set; }

            internal GetServersAtAdress(string addr) : this()
            {
                Addr = addr;
            }
        }

        /// <summary>
        /// Parameters for SteamAppsParameters.UpToDateCheck
        /// </summary>
        internal struct UpToDateCheck
        {
            internal SteamBaseParameters BaseParameters
            {
                get { return SteamdotNetFactory.CreateBaseParameters(); }
            }

            internal uint AppId { get; set; }
            internal uint Version { get; set; }

            internal UpToDateCheck(uint appid, uint version) : this()
            {
                AppId = appid;
                Version = version;
            }
        }
    }
}