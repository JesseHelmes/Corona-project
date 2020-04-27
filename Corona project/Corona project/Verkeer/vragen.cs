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
                 "wat beteken dit bord?",
                 new string[] {
                     "verboden voor fietsers",
                     "verboden voor motors",
                     "verboden voor auto's",
                     "alleen fietsers toegestaan"
                 }, 0),
             new VerkeerVraag(Properties.Resources.verkeer3,
                 "wat betekent deze bord?",
                 new string[] {
                     "Voorrangsweg",
                     "stopbord",
                     "maximaal 40 km per uur",
                     "Je moet voorrang geven"
                 }, 3),
             new VerkeerVraag(Properties.Resources.verkeer4,
                 "wat betekent deze bord?",
                 new string[] {
                     "eenrichtingsweg",
                     "doodlopend",
                     "zebrapad",
                     ""
                 }, 0),
             new VerkeerVraag(Properties.Resources.verkeer5,
                 "wat doe je bij deze licht?",
                 new string[] {
                     "doorrijden",
                     "stoppen",
                     "",
                     ""
                 }, 1),
             new VerkeerVraag(Properties.Resources.verkeer6,
                 "wat is de betekenis van dit bord?",
                 new string[] {
                     "einde voetpad",
                     "stopbord",
                     "gesloten voor voetgangers",
                     "voetpad"
                 }, 3),
             new VerkeerVraag(Properties.Resources.verkeer7,
                 "wat is de betekenis van dit bord?",
                 new string[] {
                     "aantal doorgande rijstroken",
                     "autoweg",
                     "autosnelweg",
                     "file"
                 }, 2),
             new VerkeerVraag(Properties.Resources.verkeer8,
                 "wat is de betekenis van dit bord?",
                 new string[] {
                     "zebrapad of voetgangersoversteekplats",
                     "voetgangers",
                     "gesloten voor voetgangers",
                     "erf"
                 }, 0)
        };

        public List<VerkeerVraag> getVragen()
        {
            return vragen;
        }
    }
}
