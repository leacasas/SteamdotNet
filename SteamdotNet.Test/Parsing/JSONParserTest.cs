using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Common.ISteamEconomy.Data;
using SteamdotNet.Parsing;
using SteamdotNet.Test.Common;
using System;

namespace SteamdotNet.Test.Parsing
{
    [TestClass]
    public class JSONParserTest
    {
        [TestMethod]
        public void ParseFromUrl()
        {
            const string testUrl = "http://ip.jsontest.com/";
            var parser = new JSONParser();
            var result = parser.ParseFromURL<JsonDummy>(testUrl);
            Assert.IsNotNull(result, "The parser returned a null object");
            Assert.IsInstanceOfType(result, typeof(JsonDummy), "The JSON parser failed to create an instance of the requested object");
            Assert.IsFalse(String.IsNullOrEmpty(result.Ip), "The JSON parser lost data while parsing the JSON string");
        }

        [TestMethod]
        public void SerializeObject()
        {
            const string testIP = "127.0.0.1";
            var dummyJson = new JsonDummy
            {
                Ip = testIP
            };
            var parser = new JSONParser();
            string result = parser.SerializeFromObject(dummyJson);
            Assert.IsFalse(String.IsNullOrEmpty(result), "SerializeFromObject method returned a null or empty string");
            Assert.IsTrue(result.Contains("Ip"), "The JSON returned is not valid");
            Assert.IsTrue(result.Contains(testIP), "The JSON returned is not valid");
        }

        [TestMethod]
        public void DeserializeObject()
        {
            const string json = @"{'result':{'195151':{},'16891096':{},'success':true}}";
            var parser = new JSONParser();
            var result = parser.DeserializeToObject<GetAssetClassInfo>(json);
            Assert.IsNotNull(result);
        }
    }
}