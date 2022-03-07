using System;
using System.Collections.Generic;
using System.Text;

namespace _22_02_22_classes_ex_3
{
    class CD
    {
        public string Titel;
        public string Uitvoerder;

        public CD()
        {
            Titel = "Titel";
            Uitvoerder = "Uitvoerder";

        }
        public CD(string OpvragenTitel, string OpvragenUitvoerder)
        {

            Titel = OpvragenTitel;
            Uitvoerder = OpvragenUitvoerder;
        }
    }
}
