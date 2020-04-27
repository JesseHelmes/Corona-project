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
        private VerkeerVragen verkeerVragen = new VerkeerVragen();
        private List<VerkeerVraag> vragen;

        public verkeerFrm()
        {
            InitializeComponent();

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

        private void verkeerFrm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Klik op de goede antwoord om naar de volgende vraag te gaan\n" +
                "heb je het fout kun je blijven proberen tot je de goede antwoord hebt", "Uitleg", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void laadVraag()
        {
            try
            {
                if (vraagIndex < aantalVragen)
                {
                    signPicBox.Image = vragen[vraagIndex].getImage();
                    vraagLbl.Text = UppercaseFirst(vragen[vraagIndex].getVraag());

                    for (int i = 0; i < aantalAntwoordBtns; i++)
                    {
                        antwoordBtnsArray[i].ForeColor = Color.Black;
                        antwoordBtnsArray[i].Visible = true;
                        antwoordBtnsArray[i].Text = UppercaseFirst(vragen[vraagIndex].getAntwoorden(i));

                        if (antwoordBtnsArray[i].Text == "")
                        {
                            antwoordBtnsArray[i].Visible = false;
                        }
                    }

                    antwoord = UppercaseFirst(vragen[vraagIndex].getCorrectAntwoord());
                }
                else
                {
                    signPicBox.Visible = false;
                    antwoordenFlowPnl.Visible = false;
                    vraagLbl.Text = "Je hebt alle vragen beantwoord goed zo!";
                    vraagLbl.Font = new Font(FontFamily.GenericSansSerif, 11F, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
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
                vraagIndex++;
                laadVraag();
            }
            else
            {
                btn.ForeColor = Color.Red;
            }
        }
    }
}
