using System.Drawing;

namespace Corona_project
{
    class VerkeerVraag
    {
        private Bitmap image;
        private string vraag, correctAntwoord;
        private string[] antwoorden;

        //new constructor
        public VerkeerVraag(Bitmap image, string vraag, string goedAntwoord, string antwoord1, string antwoord2 = "", string antwoord3 = "")
        {
            this.image = image;
            this.vraag = vraag;
            this.antwoorden = new string[] { goedAntwoord, antwoord1, antwoord2, antwoord3 };
            this.correctAntwoord = goedAntwoord;
            this.antwoorden.Shuffle();
        }

        //getters
        public Bitmap getImage()
        {
            return image;
        }

        public string getVraag()
        {
            return vraag;
        }

        public string getAntwoorden(int index)
        {
            return antwoorden[index];
        }

        public string getCorrectAntwoord()
        {
            return correctAntwoord;
        }
    }
}
