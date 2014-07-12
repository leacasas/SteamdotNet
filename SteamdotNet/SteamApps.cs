using SteamdotNet.Common.ISteamApps;
using SteamdotNet.Common.ISteamApps.Data;
using SteamdotNet.Parsing;

namespace SteamdotNet
{
    /// <summary>
    /// Implements the ISteamApps interface and all its methods
    /// </summary>
    public class SteamApps : BaseSteamImplementer, ISteamApps
    {
        /// <summary>
        /// ISteamApps.GetAppList
        /// </summary>
        /// <param name="parameters">GetAppList parameters(key, output format[optional], language [optional])</param>
        /// <returns>Full list of every publicly facing program in the store/library</returns>
        public GetAppList GetAppList(SteamAppsParameters.GetAppList parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/GetAppList/v2";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<GetAppList>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        /// <summary>
        /// ISteamApps.GetServersAtAddress
        /// </summary>
        /// <param name="parameters">GetServersAtAddress parameters(IPv4 address, key, output format[optional], language [optional])</param>
        /// <returns>Shows all steam-compatible servers related to a IPv4 Address. </returns>
        public GetServersAtAddress GetServersAtAddress(SteamAppsParameters.GetServersAtAddress parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/GetServersAtAddress/v1";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<GetServersAtAddress>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        /// <summary>
        /// ISteamApps.UpToDateCheck
        /// </summary>
        /// <param name="parameters">UpToDateCheck parameters(application id, version installed, key, output format[optional], language [optional])</param>
        /// <returns>Check if a given application version is the most current available. </returns>
        public UpToDateCheck UpToDateCheck(SteamAppsParameters.UpToDateCheck parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/UpToDateCheck/v1";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<UpToDateCheck>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }
    }
}