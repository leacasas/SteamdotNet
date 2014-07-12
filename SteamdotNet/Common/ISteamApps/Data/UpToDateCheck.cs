using System;
using System.Xml.Serialization;

namespace SteamdotNet.Common.ISteamApps.Data
{
    /// <summary>
    /// UpToDateCheck: root object
    /// </summary>
    public class UpToDateCheck
    {
        /// <summary>
        /// UpToDateCheck: root.response
        /// </summary>
        public UpToDateCheckResponse Response { get; set; }
    }

    /// <summary>
    /// UpToDateCheck: root.response
    /// </summary>
    [Serializable]
    [XmlRoot("response")]
    public class UpToDateCheckResponse
    {
        /// <summary>
        /// root.response.success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
        
        /// <summary>
        /// root.response.up_to_date
        /// </summary>
        [XmlElement("up_to_date")]
        public bool Up_to_date { get; set; }
        
        /// <summary>
        /// root.response.version_is_listable
        /// </summary>
        [XmlElement("version_is_listable")]
        public bool Version_is_listable { get; set; }
        
        /// <summary>
        /// root.response.required_version
        /// </summary>
        [XmlElement("required_version")]
        public int Required_version { get; set; }
        
        /// <summary>
        /// root.response.message
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }

    
}