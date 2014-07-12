using System;
using System.Xml.Serialization;

namespace SteamdotNet.Common.ISteamApps.Data
{
    /// <summary>
    /// GetServersAtAddress: Root object
    /// </summary>
    public class GetServersAtAddress
    {
        /// <summary>
        /// GetServersAtAddress: root.response
        /// </summary>
        public GetServersAtAddressResponse Response { get; set; }
    }

    /// <summary>
    /// GetServersAtAddress: root.reponse.server[]
    /// </summary>
    [Serializable]
    public class Server
    {
        /// <summary>
        /// GetServersAtAddress:  root.response.server[].addr
        /// </summary>
        [XmlElement("addr")]
        public string Addr { get; set; }

        /// <summary>
        /// GetServersAtAddress:  root.response.server[].gmsindex
        /// </summary>
        [XmlElement("gmsindex")]
        public int Gmsindex { get; set; }
        
        /// <summary>
        /// GetServersAtAddress:  root.response.server[].appid
        /// </summary>
        [XmlElement("appid")]
        public int Appid { get; set; }

        /// <summary>
        /// GetServersAtAddress:  root.response.server[].gamedir
        /// </summary>
        [XmlElement("gamedir")]
        public string Gamedir { get; set; }
        
        /// <summary>
        /// GetServersAtAddress:  root.response.server[].region
        /// </summary>
        [XmlElement("region")]
        public int Region { get; set; }
        
        /// <summary>
        /// GetServersAtAddress:  root.response.server[].secure
        /// </summary>
        [XmlElement("secure")]
        public bool Secure { get; set; }
        
        /// <summary>
        /// GetServersAtAddress:  root.response.server[].lan
        /// </summary>
        [XmlElement("lan")]
        public bool Lan { get; set; }
        
        /// <summary>
        /// GetServersAtAddress:  root.response.server[].gameport
        /// </summary>
        [XmlElement("gameport")]
        public int Gameport { get; set; }
        
        /// <summary>
        /// GetServersAtAddress:  root.response.server[].specport
        /// </summary>
        [XmlElement("specport")]
        public int Specport { get; set; }
    }

    /// <summary>
    /// GetServersAtAddress: root.response
    /// </summary>
    [Serializable]
    [XmlRoot("response")]
    public class GetServersAtAddressResponse
    {
        /// <summary>
        /// GetServersAtAddress: root.response.success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
        /// <summary>
        /// GetServersAtAddress: root.success.servers[]
        /// </summary>
        [XmlArray("servers")]
        [XmlArrayItem("server", typeof(Server))]
        public Server[] Servers { get; set; }
    }
}