using System;
using System.Xml.Serialization;

namespace SteamdotNet.Common.ISteamApps.Data
{
    /// <summary>
    /// GetAppList: Root object
    /// </summary>
    public class GetAppList
    {
        /// <summary>
        /// GetAppList: root.applist
        /// </summary>
        public AppList Applist { get; set; }
    }

    /// <summary>
    /// GetAppList: root.applist.apps
    /// </summary>
    [Serializable]
    public class App
    {
        /// <summary>
        /// GetAppList: root.applist.apps[].appid
        /// </summary>
        [XmlElement("appid")]
        public int Appid { get; set; }
        
        /// <summary>
        /// GetAppList: root.applist.apps[].name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }

    /// <summary>
    /// GetAppList: root.applist
    /// </summary>
    [Serializable]
    [XmlRoot("applist")]
    public class AppList
    {
        /// <summary>
        /// GetAppList: root.applist.apps
        /// </summary>
        [XmlArray("apps")]
        [XmlArrayItem("app", typeof(App))]
        public App[] Apps { get; set; }
    }
}