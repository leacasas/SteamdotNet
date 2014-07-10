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
    public class App
    {
        /// <summary>
        /// GetAppList: root.applist.apps[].appid
        /// </summary>
        public int Appid { get; set; }
        
        /// <summary>
        /// GetAppList: root.applist.apps[].name
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// GetAppList: root.applist
    /// </summary>
    public class AppList
    {
        /// <summary>
        /// GetAppList: root.applist.apps
        /// </summary>
        public App[] Apps { get; set; }
    }
}