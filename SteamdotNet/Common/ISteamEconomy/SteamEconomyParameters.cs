namespace SteamdotNet.Common.ISteamEconomy
{
    /// <summary>
    /// Contains the parameters for the ISteamEconomy interface.
    /// It encapsulates the parameters for each method into structs.
    /// Cannot be inherited.
    /// </summary>
    public sealed class SteamEconomyParameters
    {
        /// <summary>
        /// Parameters for ISteamEconomy.GetAssetClassInfo method.
        /// </summary>
        public struct GetAssetClassInfo
        {
            /// <summary>
            /// Key, Format and Language parameters.
            /// </summary>
            public SteamBaseParameters BaseParameters { get; private set; }

            /// <summary>
            /// AppID of game. For example, Team Fortress 2 is 440.
            /// </summary>
            public uint AppId { get; set; }

            /// <summary>
            /// Amount of class ids passed to the request.
            /// </summary>
            public uint Class_Count { get; set; }

            /// <summary>
            /// Series of sequential numbers that form a list of class ids.
            /// </summary>
            public ulong[] ClassIDn { get; set; }

            /// <summary>
            /// Instance ID of each class id passed.
            /// </summary>
            public ulong[] InstanceIDn { get; set; }

            /// <summary>
            /// Constructs the parameters for ISteamEconomy.GetAssetClassInfo
            /// </summary>
            /// <param name="appid">AppID of game. For example, Team Fortress 2 is 440.</param>
            /// <param name="classCount">Amount of class ids passed to the request.</param>
            /// <param name="classidn">Series of sequential numbers that form a list of class ids</param>
            /// <param name="instanceidn">Instance ID of each class id passed</param>
            /// <param name="key">Steam Web API developer key</param>
            /// <param name="format">Output file format</param>
            /// <param name="language">Output language (ISO 639-1 code)</param>
            public GetAssetClassInfo(
                uint appid,
                uint classCount,
                ulong[] classidn,
                ulong[] instanceidn,
                string key, 
                OutputFileFormat format = OutputFileFormat.JSON, 
                OutputLanguage language = OutputLanguage.EN) : this()
            {
                BaseParameters = new SteamBaseParameters(key, format, language);
                AppId = appid;
                Class_Count = classCount;
                ClassIDn = classidn;
                InstanceIDn = instanceidn;
            }
        }

        /// <summary>
        /// Parameters for ISteamEconomy.GetAssetPrices method.
        /// </summary>
        public struct GetAssetPrices
        {
            /// <summary>
            /// Key, Format and Language parameters.
            /// </summary>
            public SteamBaseParameters BaseParameters { get; private set; }

            /// <summary>
            /// AppID of game. For example, Team Fortress 2 is 440.
            /// </summary>
            public uint AppId { get; set; }

            /// <summary>
            /// The ISO 4217 code for currency specific filtering. For example: US dollars is USD.
            /// </summary>
            public string Currency { get; set; }

            /// <summary>
            /// Constructs the parameters for ISteamEconomy.GetAssetPrices
            /// </summary>
            /// <param name="appid">AppID of game. For example, Team Fortress 2 is 440.</param>
            /// <param name="key">Steam Web API developer key</param>
            /// <param name="format">Output file format</param>
            /// <param name="language">Output language (ISO 639-1 code)</param>
            /// <param name="currency">The ISO 4217 code for currency specific filtering. For example: US dollars is USD.</param>
            public GetAssetPrices(
                uint appid, 
                string key, 
                OutputFileFormat format = OutputFileFormat.JSON, 
                OutputLanguage language = OutputLanguage.EN, 
                string currency = "USD") : this()
            {
                BaseParameters = new SteamBaseParameters(key, format, language);
                AppId = appid;
                Currency = currency;
            }
        }
    }
}