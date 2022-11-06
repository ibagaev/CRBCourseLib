using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CRBCourseLib.Model
{
    public class ValutaDirItem
    {
        [XmlAttribute("ID")]
        public string ID { get; set; }

        [XmlElement("Name")]
        public String Name { get; set; }

        [XmlElement("EngName")]
        public String EngName { get; set; }

        [XmlElement("Nominal")]
        public String Nominal { get; set; }

        [XmlElement("ParentCode")]
        public String ParentCode { get; set; }

        [XmlElement("ISO_Num_Code")]
        public String ISO_Num_Code { get; set; }

        [XmlElement("ISO_Char_Code")]
        public String ISO_Char_Code { get; set; }
    }
}
