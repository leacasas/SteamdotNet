using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.IsFalse(String.IsNullOrEmpty(result.Ip), "The JSON has not been parsed correctly.");
        }
    }
}
