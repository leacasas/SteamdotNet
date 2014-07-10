using System;
using System.Xml.Serialization;

namespace SteamdotNet.Test.Common
{
    public class ComplexXMLDummy
    {
        public Resource Resource { get; set; }
    }

    [Serializable]
    [XmlRoot("resource")]
    public class Resource
    {
        [XmlElement("CUSTOMERList")]
        public string Customers { get; set; }

        [XmlElement("INVOICEList")]
        public string Invoices { get; set; }

        [XmlElement("ITEMList")]
        public string Items { get; set; }

        [XmlElement("PRODUCTList")]
        public string Products { get; set; }
    }
}