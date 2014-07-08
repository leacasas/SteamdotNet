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