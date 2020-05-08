using System.Collections.Generic;

namespace Corona_project
{
    class VerkeerVragen
    {
        private List<VerkeerVraag> vragen = new List<VerkeerVraag> {
            new VerkeerVraag(Properties.Resources.verkeer1,
                "wat voor bord is dit?",
                    "voorrangs bord",
                    "stop bord",
                    "een richtings weg bord",
                    "verboden toegangs bord"
                ),
             new VerkeerVraag(Properties.Resources.verkeer2,
                 "wat beteken dit bord?",
                     "verboden voor fietsers",
                     "verboden voor motors",
                     "verboden voor auto's",
                     "alleen fietsers toegestaan"
                 ),
             new VerkeerVraag(Properties.Resources.verkeer3,
                 "wat betekent deze bord?",
                     "Je moet voorrang geven",
                     "Voorrangsweg",
                     "stopbord",
                     "maximaal 40 km per uur"
                ),
             new VerkeerVraag(Properties.Resources.verkeer4,
                 "wat betekent deze bord?",
                     "eenrichtingsweg",
                     "doodlopend",
                     "zebrapad",
                     ""
                ),
             new VerkeerVraag(Properties.Resources.verkeer5,
                 "wat doe je bij deze licht?",
                    "stoppen",
                     "doorrijden",
                     "",
                     ""
                 ),
             new VerkeerVraag(Properties.Resources.verkeer6,
                 "wat is de betekenis van dit bord?",
                     "voetpad",
                     "einde voetpad",
                     "stopbord",
                     "gesloten voor voetgangers"
                ),
             new VerkeerVraag(Properties.Resources.verkeer7,
                 "wat is de betekenis van dit bord?",
                     "autosnelweg",
                     "aantal doorgande rijstroken",
                     "autoweg",
                     "file"
                 ),
             new VerkeerVraag(Properties.Resources.verkeer8,
                 "wat is de betekenis van dit bord?",
                     "zebrapad of voetgangersoversteekplats",
                     "voetgangers",
                     "gesloten voor voetgangers",
                     "erf"
                 ),
             new VerkeerVraag(Properties.Resources.verkeer9,
                 "hoeveel fietsers mogen er maximaal naast elkaar fietsen?",
                     "2",
                     "1",
                     "3",
                     "5"
                 ),
             new VerkeerVraag(Properties.Resources.verkeer10,
                 "mag je op je telefoon tijdens fietsen?",
                     "nee",
                     "ja",
                     "alleen als er geen auto's rijden",
                     ""
                 ),//https://www.verkeer-oefenen.nl/verkeer-groep-7/oversteken
             new VerkeerVraag(Properties.Resources.verkeer11,
                 "wat moet je doen als de lichten knipperen?",
                     "stoppen en wachten totdat de lichten uit zijn",
                     "door rijden",
                     "stoppen en verder rijden wanneer de spoorboom weer omhoog gaat",
                     ""
                 ),
             new VerkeerVraag(Properties.Resources.verkeer12,
                 "wanneer moet je de licht aan hebben op de fiets?",
                     "wanneer het donker, schemerig of mistig",
                     "wanneer het donker of schemerig",
                     "wanneer het schemerig of mistig",
                     "alleen in het donker"
                 ),
             new VerkeerVraag(Properties.Resources.verkeer13,
                 "wat betekend dit bord?",
                     "rotonde",
                     "rij een rondje",
                     "draai om",
                     "recyclen"
                 ),
             new VerkeerVraag(Properties.Resources.verkeer14,
                 "wat betekend dit bord?",
                     "drempel",
                     "slecht wegdek",
                     "heuvel",
                     ""
                 ),
             new VerkeerVraag(Properties.Resources.verkeer15,
                 "wat betekend dit bord?",
                     "slecht wegdek",
                     "drempel",
                     "twee heuvels",
                     ""
                 )
        };

        public List<VerkeerVraag> getVragen()
        {
            return vragen;
        }
    }
}
