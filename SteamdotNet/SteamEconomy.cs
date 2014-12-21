using SteamdotNet.Common.ISteamEconomy;
using SteamdotNet.Common.ISteamEconomy.Data;
using SteamdotNet.Parsing;

namespace SteamdotNet
{
    /// <summary>
    /// Implements the ISteamEconomy and all its methods.
    /// Methods related to games' store's assets.
    /// Cannot be inherited.
    /// </summary>
    public sealed class SteamEconomy : BaseSteamImplementer, ISteamEconomy
    {
        /// <summary>
        /// Gets the asset class information.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public GetAssetClassInfo GetAssetClassInfo(SteamEconomyParameters.GetAssetClassInfo parameters)
        {
            const string baseURL = "http://api.steampowered.com/ISteamEconomy/GetAssetClassInfo/v0001";
            BaseParser parser = ResolveParserType(parameters.BaseParameters.Format);
            return parser.ParseFromURL<GetAssetClassInfo>(SteamdotNetFactory.CreateMethodUrl(baseURL, parameters.BaseParameters, parameters));
        }

        /// <summary>
        /// Gets the asset prices.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public GetAssetPrices GetAssetPrices(SteamEconomyParameters.GetAssetPrices parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}