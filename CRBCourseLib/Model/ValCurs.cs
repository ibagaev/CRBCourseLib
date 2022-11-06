using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CRBCourseLib.Model
{
    [Serializable]
    [XmlRoot]
    public class ValCurs
    {
        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }

        [XmlElement("Valute")]
        public List<Valute> Valute { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ValCurs curs &&
                   Date == curs.Date;
        }

        public override int GetHashCode()
        {
            return 884517729 + EqualityComparer<string>.Default.GetHashCode(Date);
        }
    }


}
