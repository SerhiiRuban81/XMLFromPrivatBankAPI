using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace XMLFromPrivatBankAPI
{
    public class PbOffice
    {
        [XmlAttribute(AttributeName = "country")]
        public string Country { get; set; }
        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }
        [XmlAttribute(AttributeName = "city")]
        public string City { get; set; }
        [XmlAttribute(AttributeName = "index")]
        public string Index { get; set; }
        [XmlAttribute(AttributeName = "address")]
        public string Address { get; set; }
        [XmlAttribute(AttributeName = "phone")]
        public string Phone { get; set; }
        [XmlAttribute(AttributeName = "email")]
        public string Email { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
    [XmlRoot(ElementName ="pboffice")]
    
    public class DataOffice
    {
        [XmlElement("pboffice")]
        public List<PbOffice> Offices { get; set; } = new List<PbOffice>();
    }
}
