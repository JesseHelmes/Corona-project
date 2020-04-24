using System.Collections.Generic;

namespace Corona_project.Verkeer
{
    class VerkeerVragen
    {
        private List<VerkeerVraag> vragen = new List<VerkeerVraag> {
            new VerkeerVraag(Properties.Resources.verkeer1,
                "wat voor bord is dit?",
                new string[] {
                    "stop bord",
                    "voorrangs bord",
                    "een richtings weg bord",
                    "verboden toegangs bord"
                }, 1),
             new VerkeerVraag(Properties.Resources.verkeer2,
                 "wat beteken dit bord",
                 new string[] {
                     "verboden voor fietsers",
                     "verboden voor motors",
                     "verboden voor auto's",
                     "alleen fiets toegestaan"
                 }, 0),
             new VerkeerVraag(Properties.Resources.verkeer2,
                 "aaaaaaaadsa dbasd kanbsdksn akdjsa!!!",
                 new string[] {
                     "",
                     "sfsff",
                     "f77887",
                     "adlandlnadlasndkd"
                 }, 2)
        };

        public List<VerkeerVraag> getVragen()
        {
            return vragen;
        }
    }
}
