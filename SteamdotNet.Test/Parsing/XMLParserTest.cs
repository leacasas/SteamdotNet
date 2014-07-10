using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamdotNet.Parsing;
using SteamdotNet.Test.Common;
using System;

namespace SteamdotNet.Test.Parsing
{
    [TestClass]
    public class XMLParserTest
    {
        [TestMethod]
        public void ParseFromUrl()
        {
            const string url = "http://www.thomas-bayer.com/sqlrest/";
            var parser = new XMLParser();
            var result = parser.ParseFromURL<XMLDummy>(url);
            Assert.IsNotNull(result, "The parser returned a null object");
            Assert.IsInstanceOfType(result, typeof(XMLDummy), "The XML parser failed to create an instance of the requested object");
            Assert.IsFalse(String.IsNullOrEmpty(result.Customers), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(result.Invoices), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(result.Items), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(result.Products), "The XML parser lost data while parsing the XML string");
        }
    }
}