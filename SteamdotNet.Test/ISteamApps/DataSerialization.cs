using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common.ISteamApps;
using SteamdotNet.Common.ISteamApps.Data;
using SteamdotNet.Parsing;

namespace SteamdotNet.Test.ISteamApps
{
    [TestClass]
    public class DataSerialization
    {
        [TestMethod]
        public void TestGetAppListJSONSerialization()
        {
            var steamAppsInterface = new SteamApps();
            var parameters = new SteamAppsParameters.GetAppList("169C903286C458B4B49D90D77C447295");
            GetAppList getAppListResult = steamAppsInterface.GetAppList(parameters);
            var parser = new JSONParser();
            string serializedResult = parser.SerializeFromObject(getAppListResult);
            Assert.IsFalse(string.IsNullOrEmpty(serializedResult), "The parser returned a null or empty JSON string after trying to serialize the object");
            var deserializedResult = parser.DeserializeToObject<GetAppList>(serializedResult);
            Assert.IsNotNull(deserializedResult, "The parser returned a null object after trying to deserialize the JSON string.");
            Assert.AreEqual(getAppListResult.Applist.Apps.Length, deserializedResult.Applist.Apps.Length, "The length of the field Apps differs in value from the original");
            Assert.AreEqual(getAppListResult.Applist.Apps[0].Appid, deserializedResult.Applist.Apps[0].Appid, "The first element of the array Apps differs in value from the original (field: appid)");
            Assert.AreEqual(getAppListResult.Applist.Apps[0].Name, deserializedResult.Applist.Apps[0].Name, "The first element of the array Apps differs in value from the original (field: name)");
        }

        [TestMethod]
        public void TestGetServersAtAddressJSONSerialization()
        {
            var steamAppsInterface = new SteamApps();
            var parameters = new SteamAppsParameters.GetServersAtAddress("64.94.100.204", "169C903286C458B4B49D90D77C447295");
            GetServersAtAddress getServersAtAddressResult = steamAppsInterface.GetServersAtAddress(parameters);
            var parser = new JSONParser();
            string serializedResult = parser.SerializeFromObject(getServersAtAddressResult);
            Assert.IsFalse(string.IsNullOrEmpty(serializedResult), "The parser returned a null or empty JSON string after trying to serialize the object");
            var deserializedResult = parser.DeserializeToObject<GetServersAtAddress>(serializedResult);
            Assert.IsNotNull(deserializedResult, "The parser returned a null object after trying to deserialize the JSON string.");
            Assert.AreEqual(getServersAtAddressResult.Response.Success, deserializedResult.Response.Success, "The field Success differs in value from the original");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers.Length, deserializedResult.Response.Servers.Length, "The length of the field Servers differs in value from the original");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Addr, deserializedResult.Response.Servers[0].Addr, "The first element of the array Servers differs in value from the original (field: addr)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Appid, deserializedResult.Response.Servers[0].Appid, "The first element of the array Servers differs in value from the original (field: appid)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Gamedir, deserializedResult.Response.Servers[0].Gamedir, "The first element of the array Servers differs in value from the original (field: gamedir)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Gameport, deserializedResult.Response.Servers[0].Gameport, "The first element of the array Servers differs in value from the original (field: gameport)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Gmsindex, deserializedResult.Response.Servers[0].Gmsindex, "The first element of the array Servers differs in value from the original (field: gmsindex)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Lan, deserializedResult.Response.Servers[0].Lan, "The first element of the array Servers differs in value from the original (field: lan)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Region, deserializedResult.Response.Servers[0].Region, "The first element of the array Servers differs in value from the original (field: region)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Secure, deserializedResult.Response.Servers[0].Secure, "The first element of the array Servers differs in value from the original (field: secure)");
            Assert.AreEqual(getServersAtAddressResult.Response.Servers[0].Specport, deserializedResult.Response.Servers[0].Specport, "The first element of the array Servers differs in value from the original (field: specport)");
        }

        [TestMethod]
        public void TestUpToDateCheckJSONSerialization()
        {
            var steamAppsInterface = new SteamApps();
            var parameters = new SteamAppsParameters.UpToDateCheck(440, 1, "169C903286C458B4B49D90D77C447295");
            UpToDateCheck upToDateCheckResult = steamAppsInterface.UpToDateCheck(parameters);
            var parser = new JSONParser();
            string serializedResult = parser.SerializeFromObject(upToDateCheckResult);
            Assert.IsFalse(string.IsNullOrEmpty(serializedResult), "The parser returned a null or empty JSON string after trying to serialize the object");
            var deserializedResult = parser.DeserializeToObject<UpToDateCheck>(serializedResult);
            Assert.IsNotNull(deserializedResult, "The parser returned a null object after trying to deserialize the JSON string.");
            Assert.AreEqual(upToDateCheckResult.Response.Message, deserializedResult.Response.Message, "The field Message differs in value from the original");
            Assert.AreEqual(upToDateCheckResult.Response.Required_version, deserializedResult.Response.Required_version, "The field Required_version differs in value from the original");
            Assert.AreEqual(upToDateCheckResult.Response.Success, deserializedResult.Response.Success, "The field Success differs in value from the original");
            Assert.AreEqual(upToDateCheckResult.Response.Up_to_date, deserializedResult.Response.Up_to_date, "The field Up_to_date differs in value from the original");
            Assert.AreEqual(upToDateCheckResult.Response.Version_is_listable, deserializedResult.Response.Version_is_listable, "The field Version_is_listable differs in value from the original");
        }
    }
}