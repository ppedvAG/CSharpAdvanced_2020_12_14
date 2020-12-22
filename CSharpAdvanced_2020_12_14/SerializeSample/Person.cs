using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeSample
{

    [Serializable()] //Jetzt kann die Klasse auch binär serialisiert werden
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }

        [NonSerialized()] // Dies ist nur für Binär + Newtonsoft JSON!!!! Für XML Serialisierung oder JSON egal
        public decimal Kontostand;
    }
}
