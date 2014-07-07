using SteamdotNet.Common;

namespace SteamdotNet
{
    /// <summary>
    /// Holds the same methods as the ISteamApps interface from
    /// the Steam Web API.
    /// </summary>
    internal interface ISteamApps
    {
        SteamAppsData.GetAppListResponse GetAppList(SteamAppsParameters.GetAppList parameters);
        SteamAppsData.GetServersAtAddressResponse GetServersAtAddress(SteamAppsParameters.GetServersAtAddress parameters);
        SteamAppsData.UpToDateCheckResponse UpToDateCheck(SteamAppsParameters.UpToDateCheck parameters);
    }
}