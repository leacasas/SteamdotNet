using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common.ISteamApps;
using System;

namespace SteamdotNet.Test.ISteamApps
{
    [TestClass]
    public class URLCreation
    {
        [TestMethod]
        public void TestGetAppList()
        {
            var parameters = new SteamAppsParameters.GetAppList("169C903286C458B4B49D90D77C447295");
            string result = SteamdotNetFactory.CreateMethodUrl("http://api.steampowered.com/ISteamApps/GetAppList/v2", parameters.BaseParameters, parameters);
            Assert.IsFalse(String.IsNullOrEmpty(result), "The URL is null or empty.");
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Key));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Format.ToString()));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Language.ToString()));
        }

        [TestMethod]
        public void TestGetServersAtAddress()
        {
            var addr = "127.0.0.1";
            var parameters = new SteamAppsParameters.GetServersAtAddress(addr, "169C903286C458B4B49D90D77C447295");
            string result = SteamdotNetFactory.CreateMethodUrl("http://api.steampowered.com/ISteamApps/GetServersAtAddress/v1", parameters.BaseParameters, parameters);
            Assert.IsFalse(String.IsNullOrEmpty(result), "The URL is null or empty.");
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Key));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Format.ToString()));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Language.ToString()));
            Assert.IsTrue(result.Contains(addr));
        }

        [TestMethod]
        public void TestUpToDateCheck()
        {
            var appid = 440u;
            var version = 1u;
            var parameters = new SteamAppsParameters.UpToDateCheck(appid, version, "169C903286C458B4B49D90D77C447295");
            string result = SteamdotNetFactory.CreateMethodUrl("http://api.steampowered.com/ISteamApps/UpToDateCheck/v1", parameters.BaseParameters, parameters);
            Assert.IsFalse(String.IsNullOrEmpty(result), "The URL is null or empty.");
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Key));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Format.ToString()));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Language.ToString()));
            Assert.IsTrue(result.Contains(appid.ToString()));
            Assert.IsTrue(result.Contains(version.ToString()));
        }
    }
}