namespace SteamdotNet.Common.ISteamApps.Data
{
    /// <summary>
    /// JSON: Root object
    /// </summary>
    public class GetServersAtAddress
    {
        /// <summary>
        /// JSON: root.response
        /// </summary>
        public GetServersAtAddressResponse Response { get; set; }
    }

    /// <summary>
    /// JSON: root.reponse.server[]
    /// </summary>
    public class Server
    {
        /// <summary>
        /// JSON:  root.response.server[].addr
        /// </summary>
        public string Addr { get; set; }

        /// <summary>
        /// JSON:  root.response.server[].gmsindex
        /// </summary>
        public int Gmsindex { get; set; }
        
        /// <summary>
        /// JSON:  root.response.server[].appid
        /// </summary>
        public int Appid { get; set; }

        /// <summary>
        /// JSON:  root.response.server[].gamedir
        /// </summary>
        public string Gamedir { get; set; }
        
        /// <summary>
        /// JSON:  root.response.server[].region
        /// </summary>
        public int Region { get; set; }
        
        /// <summary>
        /// JSON:  root.response.server[].secure
        /// </summary>
        public bool Secure { get; set; }
        
        /// <summary>
        /// JSON:  root.response.server[].lan
        /// </summary>
        public bool Lan { get; set; }
        
        /// <summary>
        /// JSON:  root.response.server[].gameport
        /// </summary>
        public int Gameport { get; set; }
        
        /// <summary>
        /// JSON:  root.response.server[].specport
        /// </summary>
        public int Specport { get; set; }
    }

    /// <summary>
    /// JSON: root.response
    /// </summary>
    public class GetServersAtAddressResponse
    {
        /// <summary>
        /// JSON: root.response.success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// JSON: root.success.servers[]
        /// </summary>
        public Server[] Servers { get; set; }
    }
}