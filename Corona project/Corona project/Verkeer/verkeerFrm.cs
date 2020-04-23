using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Corona_project.Verkeer
{
    public partial class verkeerFrm : Form
    {
        private Button[] antwoordBtnsArray;
        private string antwoord;
        private int vraagIndex = 0, aantalVragen, aantalAntwoordBtns;
        VerkeerVragen verkeerVragen = new VerkeerVragen();
        List<VerkeerVraag> vragen;

        public verkeerFrm()
        {
            InitializeComponent();
            /*
             new antwoorden en afbeelding laden
             als dit met database gaat kan ik die van stage gebruiken.. maar
             dat is niet mvc..
             */
            antwoordBtnsArray = new Button[] { antwoordBtn1, antwoordBtn2, antwoordBtn3, antwoordBtn4 };
            vragen = verkeerVragen.getVragen();

            aantalVragen = vragen.Count;
            aantalAntwoordBtns = antwoordBtnsArray.Length;
        }

        private void verkeerFrm_Load(object sender, EventArgs e)
        {
            vragen.Shuffle();
            laadVraag();
        }

        public void laadVraag()
        {
            try
            {
                if (vraagIndex < aantalVragen)
                {
                    signPicBox.Image = vragen[vraagIndex].getImage();
                    vraagLbl.Text = vragen[vraagIndex].getVraag();

                    for (int i = 0; i < aantalAntwoordBtns; i++)
                    {
                        antwoordBtnsArray[i].ForeColor = Color.Black;
                        antwoordBtnsArray[i].Visible = true;
                        antwoordBtnsArray[i].Text = vragen[vraagIndex].getAntwoorden(i);

                        if (antwoordBtnsArray[i].Text == "")
                        {
                            antwoordBtnsArray[i].Visible = false;
                        }
                    }

                    antwoord = vragen[vraagIndex].getCorrectAntwoord();
                }
            }
            catch (Exception ex)
            {
                //throw;
                Debug.WriteLine(ex);
            }
        }

        private void controlleerAntwoord(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < aantalAntwoordBtns; i++)
            {
                antwoordBtnsArray[i].ForeColor = Color.Black;
            }
            if (btn.Text == antwoord)
            {
                Debug.WriteLine("goed zo!");
                vraagIndex++;
                laadVraag();
            }
            else
            {
                btn.ForeColor = Color.Red;
                Debug.WriteLine("fout!");
            }
        }
    }
}
