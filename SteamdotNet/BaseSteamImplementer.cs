using SteamdotNet.Common;
using SteamdotNet.Parsing;

namespace SteamdotNet
{
    /// <summary>
    /// Base class for all the interface implementation.
    /// This class holds common helper functions for all the
    /// interface implementations.
    /// </summary>
    public class BaseSteamImplementer
    {
        /// <summary>
        /// Returns the most suitable parser for the given output format
        /// </summary>
        /// <param name="fileFormat">Output file format</param>
        /// <returns>The most suitable parser object</returns>
        protected BaseParser ResolveParserType(OutputFileFormat fileFormat)
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
