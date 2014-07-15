using SteamdotNet.Common.ISteamEconomy;
using SteamdotNet.Common.ISteamEconomy.Data;

namespace SteamdotNet
{
    /// <summary>
    /// Methods related to games' store's assets
    /// </summary>
    internal interface ISteamEconomy
    {
        GetAssetClassInfo GetAssetClassInfo(SteamEconomyParameters.GetAssetClassInfo parameters);
        GetAssetPrices GetAssetPrices(SteamEconomyParameters.GetAssetPrices parameters);
    }
}