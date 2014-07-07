using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common;

namespace SteamdotNet.Test.ISteamApps
{
    [TestClass]
    public class URLCreation
    {
        [TestMethod]
        public void TestGetAppList()
        {
            var parameters = new SteamAppsParameters.GetAppList();
            var result = SteamdotNetFactory.CreateMethodUrl("http://api.steampowered.com/ISteamApps/GetAppList/v2", parameters.BaseParameters, parameters);
            Assert.IsFalse(String.IsNullOrEmpty(result), "The URL is null or empty.");
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Key));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Format.ToString()));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Language));
        }
        
        [TestMethod]
        public void TestGetServersAtAddress()
        {
            var parameters = new SteamAppsParameters.GetServersAtAddress("127.0.0.1");
            var result = SteamdotNetFactory.CreateMethodUrl("http://api.steampowered.com/ISteamApps/GetServersAtAddress/v1", parameters.BaseParameters, parameters);
            Assert.IsFalse(String.IsNullOrEmpty(result), "The URL is null or empty.");
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Key));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Format.ToString()));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Language));
            Assert.IsTrue(result.Contains(parameters.Addr));
        }

        [TestMethod]
        public void TestUpToDateCheck()
        {
            var parameters = new SteamAppsParameters.UpToDateCheck(440, 1);
            var result = SteamdotNetFactory.CreateMethodUrl("http://api.steampowered.com/ISteamApps/UpToDateCheck/v1", parameters.BaseParameters, parameters);
            Assert.IsFalse(String.IsNullOrEmpty(result), "The URL is null or empty.");
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Key));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Format.ToString()));
            Assert.IsTrue(result.Contains(parameters.BaseParameters.Language));
            Assert.IsTrue(result.Contains(parameters.AppId.ToString()));
            Assert.IsTrue(result.Contains(parameters.Version.ToString()));
        }
    }
}