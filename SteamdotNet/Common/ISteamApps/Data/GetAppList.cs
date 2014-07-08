namespace SteamdotNet.Common.ISteamApps.Data
{
    /// <summary>
    /// JSON: Root object
    /// </summary>
    public class GetAppList
    {
        /// <summary>
        /// JSON: root.applist
        /// </summary>
        public AppList Applist { get; set; }
    }

    /// <summary>
    /// JSON: root.applist.apps
    /// </summary>
    public class App
    {
        /// <summary>
        /// JSON: root.applist.apps[].appid
        /// </summary>
        public int Appid { get; set; }
        
        /// <summary>
        /// JSON: root.applist.apps[].name
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// JSON: root.applist
    /// </summary>
    public class AppList
    {
        /// <summary>
        /// JSON: root.applist.apps
        /// </summary>
        public App[] Apps { get; set; }
    }
}