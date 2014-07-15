using SteamdotNet.Common.ISteamApps.Data;

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
        /// Parameters for ISteamEconomy.GetAssetClassInfo
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
            /// <param name="classCount"></param>
            /// <param name="classidn"></param>
            /// <param name="instanceidn"></param>
            /// <param name="key"></param>
            /// <param name="format"></param>
            /// <param name="language"></param>
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
    }
}