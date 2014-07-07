using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SteamdotNet.Test.Parsing.JSONParser
{
    [TestClass]
    public class JSONParserTest
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
