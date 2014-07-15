using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common.ISteamEconomy;
using System;

namespace SteamdotNet.Test.ISteamEconomy
{
    [TestClass]
    public class URLCreation
    {
        [TestMethod]
        public void TestGetAssetClassInfo()
        {
            var appId = 440u;
            var classCount = 2u;
            var classIds = new ulong[] {195151, 16891096};
            var instanceIds = new ulong[] {};
            var parameters = new SteamEconomyParameters.GetAssetClassInfo(appId, classCount, classIds, instanceIds, "169C903286C458B4B49D90D77C447295");
            string result = SteamdotNetFactory.CreateMethodUrl("http://api.steampowered.com/ISteamEconomy/GetAssetClassInfo/v0001", parameters.BaseParameters, parameters);
            Assert.IsFalse(String.IsNullOrEmpty(result), "The URL is null or empty.");
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Key));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Format.ToString()));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Language.ToString()));
            Assert.IsTrue(result.Contains(appId.ToString()));
            Assert.IsTrue(result.Contains(classCount.ToString()));
            Assert.IsTrue(result.Contains(classIds[0].ToString()));
            Assert.IsTrue(result.Contains(classIds[1].ToString()));
        }
    }
}