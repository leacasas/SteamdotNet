using System.Collections.Generic;

namespace SteamdotNet.Common.ISteamEconomy.Data
{
    public class GetAssetClassInfo
    {
        public GetAssetClassInfoResult Result { get; set; }
    }

    public class GetAssetClassInfoResult
    {
        public Dictionary<ulong, object> Dic { get; set; }
        public bool Success { get; set; }
    }
}