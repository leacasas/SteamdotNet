namespace SteamdotNet.Common.SteamApps
{
    /// <summary>
    /// 
    /// </summary>
    public class GetServersAtAddress
    {
        /// <summary>
        /// 
        /// </summary>
        public GetServersAtAddressResponse Response { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Server
    {
        /// <summary>
        /// 
        /// </summary>
        public string Addr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Gmsindex { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Appid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Gamedir { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Region { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Secure { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Lan { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Gameport { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Specport { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class GetServersAtAddressResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Server[] Servers { get; set; }
    }
}