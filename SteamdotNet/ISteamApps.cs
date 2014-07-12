using SteamdotNet.Common.ISteamApps;
using SteamdotNet.Common.ISteamApps.Data;

namespace SteamdotNet
{
    /// <summary>
    /// Holds the same methods as the ISteamApps interface from
    /// the Steam Web API.
    /// </summary>
    internal interface ISteamApps
    {
        GetAppList GetAppList(SteamAppsParameters.GetAppList parameters);
        GetServersAtAddress GetServersAtAddress(SteamAppsParameters.GetServersAtAddress parameters);
        UpToDateCheck UpToDateCheck(SteamAppsParameters.UpToDateCheck parameters);
    }
}