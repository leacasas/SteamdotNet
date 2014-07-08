namespace SteamdotNet.Common.ISteamApps.Data
{
    /// <summary>
    /// JSON: root object
    /// </summary>
    public class UpToDateCheck
    {
        /// <summary>
        /// JSON: root.response
        /// </summary>
        public UpToDateCheckResponse Response { get; set; }
    }

    /// <summary>
    /// JSON: root.response
    /// </summary>
    public class UpToDateCheckResponse
    {
        /// <summary>
        /// root.response.success
        /// </summary>
        public bool Success { get; set; }
        
        /// <summary>
        /// root.response.up_to_date
        /// </summary>
        public bool Up_to_date { get; set; }
        
        /// <summary>
        /// root.response.version_is_listable
        /// </summary>
        public bool Version_is_listable { get; set; }
        
        /// <summary>
        /// root.response.required_version
        /// </summary>
        public int Required_version { get; set; }
        
        /// <summary>
        /// root.response.message
        /// </summary>
        public string Message { get; set; }
    }

    
}