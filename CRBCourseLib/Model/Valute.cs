using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CRBCourseLib.Model
{
    public class Valute
    {
        [XmlAttribute(AttributeName = "ID")]
        public String ID { get; set; }

        [XmlElement(ElementName = "NumCode")]
        public String NumCode { get; set; }

        [XmlElement(ElementName = "CharCode")]
        public String CharCode { get; set; }

        [XmlElement(ElementName = "Nominal")]
        public String Nominal { get; set; }

        [XmlElement(ElementName = "Name")]
        public String Name { get; set; }

        [XmlElement(ElementName = "Value")]
        public String Value { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Valute valute &&
                   NumCode == valute.NumCode &&
                   CharCode == valute.CharCode;
        }

        public override int GetHashCode()
        {
            int hashCode = 402942806;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NumCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CharCode);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Nominal} {CharCode} = {Value} RUB";
        }


    }
}
