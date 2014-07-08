using SteamdotNet.Common;
using SteamdotNet.Common.SteamApps;
using SteamdotNet.Parsing;

namespace SteamdotNet
{
    /// <summary>
    /// 
    /// </summary>
    public class SteamApps : ISteamApps
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public GetAppList GetAppList(SteamAppsParameters.GetAppList parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/GetAppList/v2";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<GetAppList>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public GetServersAtAddress GetServersAtAddress(SteamAppsParameters.GetServersAtAddress parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/GetServersAtAddress/v1";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<GetServersAtAddress>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public UpToDateCheck UpToDateCheck(SteamAppsParameters.UpToDateCheck parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/UpToDateCheck/v1";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<UpToDateCheck>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        private BaseParser ResolveParserType(OutputFileFormat fileFormat)
        {
            switch (fileFormat)
            {
                case OutputFileFormat.JSON:
                    return new JSONParser();
                case OutputFileFormat.VDF:
                    return new VDFParser();
                case OutputFileFormat.XML:
                    return new XMLParser();
                default:
                    return new JSONParser();
            }
        }
    }
}