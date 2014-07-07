using SteamdotNet.Common;
using SteamdotNet.Parsing;

namespace SteamdotNet
{
    internal class SteamApps : ISteamApps
    {
        public SteamAppsData.GetAppListResponse GetAppList(SteamAppsParameters.GetAppList parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/GetAppList/v2";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<SteamAppsData.GetAppListResponse>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        public SteamAppsData.GetServersAtAddressResponse GetServersAtAddress(SteamAppsParameters.GetServersAtAddress parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/GetServersAtAddress/v1";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<SteamAppsData.GetServersAtAddressResponse>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        public SteamAppsData.UpToDateCheckResponse UpToDateCheck(SteamAppsParameters.UpToDateCheck parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamApps/UpToDateCheck/v1";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<SteamAppsData.UpToDateCheckResponse>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
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
                    return new XMLParser(); ;
                default:
                    return new JSONParser();
            }
        }
    }
}