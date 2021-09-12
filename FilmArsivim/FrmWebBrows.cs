using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FilmArsivim
{
    public partial class FrmWebBrows : Form
    {
        public FrmWebBrows()
        {
            InitializeComponent();
        }
        public string deger;
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void FrmWebBrows_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmWebBrows_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void FrmWebBrows_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Close();
            }
        }

        private void FrmWebBrows_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fc = Application.OpenForms["Form1"];
            if (fc != null)
            {
                Form1 fr = new Form1();
                fr.Show();

            }






        }
    }
}
