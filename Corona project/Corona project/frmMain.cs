using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona_project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Load form 
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        //Klik op Button Rekenspel
        private void btnRekenSpel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rekenen geklikt");
        }

        //Klik op Button Topospel
        private void btnTopoSpel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Topo geklikt");
        }

        //Klik op Button Nederland&Engels
        private void btnNederlandsEngelsSpel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nederlands en Engels geklikt");
        }

        //Klik op Button TekenCanvas
        private void btnTekenCanvas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TekenCanvas geklikt");
        }

        //Klik op Button Verkeer
        private void btnVerkeerSpel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verkeer geklikt");
        }


    }
}
