using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace Corona_project.TOPO
{

    public partial class frmTopo : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        string[] provinces = { "Gelderland", "Drenthe", "Overijsel", "Groningen", "Friesland", "Flevoland", "Utrecht",
                                    "Noord-Brabant", "Limburg", "Zeeland", "Zoud-Holland", "Noord-Holland" };
        string[] rprovinces;

        int points = 0;
        int currentIndex = 0;
        public frmTopo()
        {
            InitializeComponent();


        }

        /*
        private void MouseMoveTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            var c = GetColorAt(cursor);
            this.BackColor = c;

            if (c.R == 255 && c.G == 127 && c.B == 39)
            {
                MessageBox.Show("Gelderland");
            }
        }
        */

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private string PollPixel(Point location, Color color)
        {
            
            string province = "";
            var c = GetColorAt(location);
            // 12 provincies
            if (c.R == 255 && c.G == 127 && c.B == 39)
            {
                province = "Gelderland";
            }
            else if (c.R == 236 && c.G == 28 && c.B == 36)
            {
                province = "Drenthe";
            }
            else if (c.R == 0 && c.G == 168 && c.B == 243)
            {
                province = "Overijsel";
            }
            else if (c.R == 255 && c.G == 174 && c.B == 200)
            {
                province = "Groningen";
            }
            else if (c.R == 185 && c.G == 122 && c.B == 86)
            {
                province = "Friesland";
            }
            else if (c.R == 63 && c.G == 72 && c.B == 204)
            {
                province = "Flevoland";
            }
            else if (c.R == 14 && c.G == 209 && c.B == 69)
            {
                province = "Utrecht";
            }
            else if (c.R == 189 && c.G == 19 && c.B == 144)
            {
                province = "Noord-Brabant";
            }
            else if (c.R == 255 && c.G == 242 && c.B == 0)
            {
                province = "Limburg";
            }
            else if (c.R == 77 && c.G == 122 && c.B == 190)
            {
                province = "Zeeland";
            }
            else if (c.R == 95 && c.G == 13 && c.B == 182)
            {
                province = "Zoud-Holland";
            }
            else if (c.R == 228 && c.G == 169 && c.B == 6)
            {
                province = "Noord-Holland";
            }
            return province;
            // By calling Thread.Sleep() without a parameter, we are signaling to the
            // operating system that we only want to sleep long enough for other
            // applications.  As soon as the other apps yield their CPU time, we will
            // regain control.
            //Thread.Sleep(250);
           
        }

        private void frmTopo_Load(object sender, EventArgs e)
        {
            lbxAnswer.Items.Clear();
            lblCurrentPoints.Text = points.ToString();

            Random randy = new Random();
            int rindex;

            for (int i = 0; i < provinces.Length; i++)
            {
                rindex = province(randy);
            }
            askQuest();
            
           
            
            pcbMap.Image = Properties.Resources.knp;

        }

        private void askQuest()
        {
            lblProvince.Text = rprovinces[currentIndex];
        }

        private int province(Random randy)
        {
            
            int rindex;
            {
                do
                {
                    rindex = randy.Next(provinces.Length);
                } while (lbxAnswer.Items.IndexOf(provinces[rindex]) != -1);
                //var query = provinces.Select((province, index) => new { rindex, str = province.Substring(0) });
                Console.WriteLine("{0}", provinces[rindex]);
                lbxAnswer.Items.Add(provinces[rindex]);
                rprovinces = lbxAnswer.Items.OfType<string>().ToArray();
            }
            
            return rindex;
        }
      
        private void pcbMap_Click(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            var c = GetColorAt(cursor);
            //this.BackColor = c;
            if(lblProvince != null)
            {
                
                if (lblProvince.Text == PollPixel(MousePosition, c))
                {
                    points += 1;
                    lblCurrentPoints.Text = points.ToString();
                    currentIndex += 1;
                    if (currentIndex != 12) 
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
                else if(lblProvince.Text != PollPixel(MousePosition, c))
                {
                    currentIndex += 1;
                    if (currentIndex != 12)
                    {
                        lblProvince.Text = rprovinces[currentIndex];
                        askQuest();
                    }
                    else
                    {
                        ShowMessageBox();
                    }
                }
            }
            
            
        }


         private void ShowMessageBox()
        {
            string message = "Gefeliciteerd je bent klaar an hebt " + lblCurrentPoints.Text + " punten behaald!";
            string caption = "Finished";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message + "\n" + "Will je opnieuw proberen?", caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                frmTopo NewForm = new frmTopo();
                NewForm.Show();
                this.Dispose(false);
            }
            else if(result == System.Windows.Forms.DialogResult.No)
            {
                // Closes the parent form.
                this.Close();
            }
         }
    }



}
