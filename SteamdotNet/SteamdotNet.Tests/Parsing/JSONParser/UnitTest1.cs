using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SteamdotNet.Tests.Parsing.JSONParser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var parser = new SteamdotNet.Parsing.JSON.JSONParser();
            string result = parser.ReadJSONfromURL();
            Assert.IsFalse(String.IsNullOrEmpty(result));
            Assert.IsFalse(String.IsNullOrWhiteSpace(result));
        }
    }
}