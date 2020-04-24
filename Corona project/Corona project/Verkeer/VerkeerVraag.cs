using System.Drawing;

namespace Corona_project.Verkeer
{
    class VerkeerVraag
    {
        private Bitmap image;
        private string vraag, correctAntwoord;
        private string[] antwoorden;

        public VerkeerVraag(Bitmap image, string vraag, string[] antwoorden, int goedeAntwoordUitAntwoorden)
        {
            this.image = image;
            this.vraag = vraag;
            this.antwoorden = antwoorden;
            this.correctAntwoord = antwoorden[goedeAntwoordUitAntwoorden];
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
