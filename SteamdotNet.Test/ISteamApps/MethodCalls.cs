using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common.ISteamApps;
using SteamdotNet.Common.ISteamApps.Data;

namespace SteamdotNet.Test.ISteamApps
{
    [TestClass]
    public class MethodCalls
    {
        [TestMethod]
        public void TestGetAppList()
        {
            var steamAppsInterface = new SteamApps();
            var parameters = new SteamAppsParameters.GetAppList("169C903286C458B4B49D90D77C447295");
            GetAppList result = steamAppsInterface.GetAppList(parameters);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (GetAppList));
            Assert.IsNotNull(result.Applist);
            Assert.IsInstanceOfType(result.Applist, typeof (AppList));
            Assert.IsNotNull(result.Applist.Apps);
            Assert.IsInstanceOfType(result.Applist.Apps, typeof (App[]));
            Assert.IsTrue(result.Applist.Apps.Length > 0);
            Assert.IsInstanceOfType(result.Applist.Apps[0], typeof (App));
        }

        [TestMethod]
        public void TestGetServersAtAddress()
        {
            var steamAppsInterface = new SteamApps();
            var parameters = new SteamAppsParameters.GetServersAtAddress("64.94.100.204", "169C903286C458B4B49D90D77C447295");
            GetServersAtAddress result = steamAppsInterface.GetServersAtAddress(parameters);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (GetServersAtAddress));
            Assert.IsNotNull(result.Response);
            Assert.IsInstanceOfType(result.Response, typeof (GetServersAtAddressResponse));
            Assert.IsNotNull(result.Response.Success);
            Assert.IsInstanceOfType(result.Response.Success, typeof (bool));
            Assert.IsNotNull(result.Response.Servers);
            Assert.IsInstanceOfType(result.Response.Servers, typeof (Server[]));
        }

        [TestMethod]
        public void TestUpToDateCheck()
        {
            var steamAppsInterface = new SteamApps();
            var parameters = new SteamAppsParameters.UpToDateCheck(440, 1, "169C903286C458B4B49D90D77C447295");
            UpToDateCheck result = steamAppsInterface.UpToDateCheck(parameters);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (UpToDateCheck));
            Assert.IsNotNull(result.Response);
            Assert.IsInstanceOfType(result.Response, typeof (UpToDateCheckResponse));
            Assert.IsFalse(string.IsNullOrEmpty(result.Response.Message));
            Assert.IsInstanceOfType(result.Response.Required_version, typeof (int));
            Assert.IsInstanceOfType(result.Response.Success, typeof (bool));
            Assert.IsInstanceOfType(result.Response.Up_to_date, typeof (bool));
            Assert.IsInstanceOfType(result.Response.Version_is_listable, typeof (bool));
        }
    }
}