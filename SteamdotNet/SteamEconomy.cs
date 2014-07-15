using SteamdotNet.Common.ISteamEconomy;
using SteamdotNet.Common.ISteamEconomy.Data;

namespace SteamdotNet
{
    /// <summary>
    /// Implements the ISteamEconomy and all its methods.
    /// Methods related to games' store's assets.
    /// Cannot be inherited.
    /// </summary>
    public sealed class SteamEconomy : BaseSteamImplementer, ISteamEconomy
    {
        public GetAssetClassInfo GetAssetClassInfo(SteamEconomyParameters.GetAssetClassInfo parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}