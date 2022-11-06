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
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot("Valuta", Namespace = "", IsNullable = false)]
    public class ValutaDir
    {
        [XmlElement("Item")]
        public List<ValutaDirItem> Items { get; set; }
    }
}
