namespace SteamdotNet.Common.SteamApps
{
    /// <summary>
    /// 
    /// </summary>
    public class UpToDateCheckResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Up_to_date { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Version_is_listable { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Required_version { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class UpToDateCheck
    {
        /// <summary>
        /// 
        /// </summary>
        public UpToDateCheckResponse Response { get; set; }
    }
}