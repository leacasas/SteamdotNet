using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common;
using SteamdotNet.Common.ISteamApps;
using SteamdotNet.Exceptions;
using System;

namespace SteamdotNet.Test.Common
{
    [TestClass]
    public class Parameters
    {
        [TestMethod]
        public void TestInvalidParametersException()
        {
            try
            {
                new SteamBaseParameters(null);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(InvalidDeveloperKeyException));
                Assert.IsFalse(String.IsNullOrEmpty(ex.Message));
            }

            try
            {
                new SteamAppsParameters.GetAppList(null);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(InvalidDeveloperKeyException));
                Assert.IsFalse(String.IsNullOrEmpty(ex.Message));
            }

            try
            {
                var getServersAtAddressParams = new SteamAppsParameters.GetServersAtAddress(string.Empty, null);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(InvalidDeveloperKeyException));
                Assert.IsFalse(String.IsNullOrEmpty(ex.Message));
            }

            try
            {
                var upToDateCheckParams = new SteamAppsParameters.UpToDateCheck(default(uint), default(uint), null);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(InvalidDeveloperKeyException));
                Assert.IsFalse(String.IsNullOrEmpty(ex.Message));
            }
        }
    }
}