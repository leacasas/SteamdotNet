using System;
using System.Xml.Serialization;

namespace SteamdotNet.Test.Common
{
    [Serializable]
    [XmlRoot("resource")]
    public class XMLDummy
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