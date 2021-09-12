using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=FilmArsivim;Integrated Security=True")
        {

        };
        public string link;

        public Form1()
        {
            InitializeComponent();
        }
        void filmler()
        {
            SqlDataAdapter da=new SqlDataAdapter("select ID, Name as 'Film Adı', Category as 'Kategori'  from TblFilm", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(TxtCategory.Text.Trim()!=""&& TxtLink.Text.Trim()!=""&&TxtName.Text.Trim()!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblFilm (Name,Category,Link) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtName.Text);
                komut.Parameters.AddWithValue("@p2", TxtCategory.Text);
                if (TxtLink.Text.Length < 201)
                {
                    komut.Parameters.AddWithValue("@p3", TxtLink.Text);
                }
                else
                {
                    MessageBox.Show("Link Çok Uzun");
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Film, Listeye Eklendi", "Kayıt Bilgilendirmesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filmler();
            }
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void baglantin()
        {
            baglanti.Open();
        }
        string a;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglantin();

            int secilen = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            SqlCommand komut1 = new SqlCommand("select Link from TblFilm where ID=@p1",baglanti);
            komut1.Parameters.AddWithValue("@p1", secilen);
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                link= dr[0].ToString();

            }
            a = link;
            webBrowser1.Navigate(a);
            baglanti.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje İbrahim YILDIZ tarafından 12.09.2021 tarihinde kodlaması yapılmıştır.","Hakkımızda",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random ra = new Random();
            int random = ra.Next(1,5);

            label5.Text = random.ToString();
            
            if (random==1)
            {
                
                pictureBox3.BackColor = Color.Black;
                panel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
                panel3.BackColor = Color.Black;
                panel4.BackColor = Color.Black;
                groupBox1.BackColor = Color.Black;
                groupBox2.BackColor = Color.Black;
                groupBox3.BackColor = Color.Black;
                groupBox4.BackColor = Color.Black;
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                dataGridView1.BackgroundColor = Color.Black;
                BtnSave.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                BtnExit.BackColor = Color.Black;
            }
            if (random == 2)
            {

                pictureBox3.BackColor = this.BackColor;
                panel1.BackColor = this.BackColor;
                panel2.BackColor = this.BackColor;
                panel3.BackColor = this.BackColor;
                panel4.BackColor = this.BackColor;
                groupBox1.BackColor = this.BackColor;
                groupBox2.BackColor = this.BackColor;
                groupBox3.BackColor = this.BackColor;
                groupBox4.BackColor = this.BackColor;
                label1.BackColor = this.BackColor;
                label2.BackColor = this.BackColor;
                label3.BackColor = this.BackColor;
                label4.BackColor = this.BackColor;
                dataGridView1.BackgroundColor = this.BackColor;
                BtnSave.BackColor = this.BackColor;
                button1.BackColor = this.BackColor;
                button2.BackColor = this.BackColor;
                button3.BackColor = this.BackColor;
                BtnExit.BackColor = this.BackColor;
            }
            if (random == 3)
            {

                pictureBox3.BackColor = Color.CadetBlue;
                panel1.BackColor = Color.CadetBlue;
                panel2.BackColor = Color.CadetBlue;
                panel3.BackColor = Color.CadetBlue;
                panel4.BackColor = Color.CadetBlue;
                groupBox1.BackColor = Color.CadetBlue;
                groupBox2.BackColor = Color.CadetBlue;
                groupBox3.BackColor = Color.CadetBlue;
                groupBox4.BackColor = Color.CadetBlue;
                label1.BackColor = Color.CadetBlue;
                label2.BackColor = Color.CadetBlue;
                label3.BackColor = Color.CadetBlue;
                label4.BackColor = Color.CadetBlue;
                dataGridView1.BackgroundColor = Color.CadetBlue;
                BtnSave.BackColor = Color.CadetBlue;
                button1.BackColor = Color.CadetBlue;
                button2.BackColor = Color.CadetBlue;
                button3.BackColor = Color.CadetBlue;
                BtnExit.BackColor = Color.CadetBlue;

            }
            if (random == 4)
            {

                pictureBox3.BackColor = Color.DarkGray;
                panel1.BackColor = Color.DarkGray;
                panel2.BackColor = Color.DarkGray;
                panel3.BackColor = Color.DarkGray;
                panel4.BackColor = Color.DarkGray;
                groupBox1.BackColor = Color.DarkGray;
                groupBox2.BackColor = Color.DarkGray;
                groupBox3.BackColor = Color.DarkGray;
                groupBox4.BackColor = Color.DarkGray;
                label1.BackColor = Color.DarkGray;
                label2.BackColor = Color.DarkGray;
                label3.BackColor = Color.DarkGray;
                label4.BackColor = Color.DarkGray;
                dataGridView1.BackgroundColor = Color.DarkGray;
                BtnSave.BackColor = Color.DarkGray;
                button1.BackColor = Color.DarkGray;
                button2.BackColor = Color.DarkGray;
                button3.BackColor = Color.DarkGray;
                BtnExit.BackColor = Color.DarkGray;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Dispose();
            FrmWebBrows fr = new FrmWebBrows();
            fr.Show();
            fr.webBrowser2.Navigate(a);
            this.Hide();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
