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
            var parsedXMLDummy = parser.ParseFromURL<XMLDummy>(url);
            Assert.IsNotNull(parsedXMLDummy, "The parser returned a null object");
            Assert.IsInstanceOfType(parsedXMLDummy, typeof(XMLDummy), "The XML parser failed to create an instance of the requested object");
            Assert.IsFalse(String.IsNullOrEmpty(parsedXMLDummy.Customers), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(parsedXMLDummy.Invoices), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(parsedXMLDummy.Items), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(parsedXMLDummy.Products), "The XML parser lost data while parsing the XML string");
            var parsedComplexDummy = parser.ParseFromURL<ComplexXMLDummy>(url);
            Assert.IsNotNull(parsedComplexDummy, "The parser returned a null object");
            Assert.IsInstanceOfType(parsedComplexDummy, typeof(ComplexXMLDummy), "The XML parser failed to create an instance of the requested object");
            Assert.IsFalse(String.IsNullOrEmpty(parsedComplexDummy.Resource.Customers), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(parsedComplexDummy.Resource.Invoices), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(parsedComplexDummy.Resource.Items), "The XML parser lost data while parsing the XML string");
            Assert.IsFalse(String.IsNullOrEmpty(parsedComplexDummy.Resource.Products), "The XML parser lost data while parsing the XML string");
        }
    }
}