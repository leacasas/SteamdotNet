using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common.ISteamEconomy;
using SteamdotNet.Common.ISteamEconomy.Data;

namespace SteamdotNet.Test.ISteamEconomy
{
    [TestClass]
    public class MethodCalls
    {
        [TestMethod]
        public void TestGetAssetClassInfo()
        {
            var appId = 440u;
            var classCount = 2u;
            var classIds = new ulong[] { 195151, 16891096 };
            var instanceIds = new ulong[] { };
            var steamEconomyInterface = new SteamEconomy();
            var parameters = new SteamEconomyParameters.GetAssetClassInfo(appId, classCount, classIds, instanceIds, "169C903286C458B4B49D90D77C447295");
            GetAssetClassInfo result = steamEconomyInterface.GetAssetClassInfo(parameters);
            Assert.IsNotNull(result);
        }
    }
}