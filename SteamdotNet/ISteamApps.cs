using SteamdotNet.Common.ISteamApps;
using SteamdotNet.Common.ISteamApps.Data;

namespace SteamdotNet
{
    /// <summary>
    /// Methods related to the Steam APIs in general
    /// </summary>
    internal interface ISteamApps
    {
        GetAppList GetAppList(SteamAppsParameters.GetAppList parameters);
        GetServersAtAddress GetServersAtAddress(SteamAppsParameters.GetServersAtAddress parameters);
        UpToDateCheck UpToDateCheck(SteamAppsParameters.UpToDateCheck parameters);
    }
}