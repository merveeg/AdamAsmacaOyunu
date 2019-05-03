using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace adamasmacaoyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            oyunuBaslat();
        }
        private void oyunuBaslat()
        {
            int solTaraf = 4;
            pnlHarfler.Controls.Clear();
            Random rnd = new Random(DateTime.Now.Millisecond);
            int indis = rnd.Next(0, Kelimeler.Length); //Dizinin kaçıncı elemanını yazıcam
            SeciliKelime = Kelimeler[indis];
            //foreach (var item in SeciliKelime.ToCharArray())
            //{
            //    Label lbl = new Label();
            //    lbl.AutoSize = false;
            //    lbl.Text = "_";
            //    lbl.Top = 5;
            //    lbl.Left = solTaraf;
            //    lbl.Tag = item.ToString();
            //    lbl.Width = 15;
            //    pnlHarfler.Controls.Add(lbl);
            //    solTaraf += 15;

            //    lbl.Refresh();
            //}
            for (int i = 0; i < SeciliKelime.Length; i++)
            {
                TextBox txtbx = new TextBox();
                pnlHarfler.Controls.Add(txtbx);
                txtbx.Top = 30;
                txtbx.Left = solTaraf;
                txtbx.Width = 30;
                txtbx.Text = "_";
                txtbx.Tag = SeciliKelime[i];
                solTaraf += 40;
                txtbx.BackColor = Color.LightSalmon;

                txtbx.Refresh();


                /*Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Text = "_";
                lbl.Top = 5;
                lbl.Left = solTaraf;
                lbl.Tag = SeciliKelime[i];
                lbl.Width = 15;
                pnlHarfler.Controls.Add(lbl);
                solTaraf += 15;
                lbl.Refresh();
                */
            }
            pnlHarfler.Refresh();
            //lblYanlis.Clear();
        }
        int kullaniciHak = 0;
        string lblText = "";
        string SeciliKelime = "";
        public string[] Kelimeler = { "OYUN", "GÖZ", "İSTANBUL","KALEM"};
        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = @"C:\Users\33.PNG"
            //pictureBox1.Load(@"C:\Users\33.PNG");
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
            pnlHarfler.BackColor = Color.DarkGreen;
            var girilenHarf = textBox1.Text.ToUpper();
            if (string.IsNullOrEmpty(girilenHarf))
            {
                return;
            }
            //List<string> matris = new List<string>();
            //foreach (var item in lblYanlis.Text)
            //{
            //    matris.Add(item.ToString());
            //}

            //lblYanlis.Text = textBox1.Text;

            if (lblYanlis.Text.ToUpper().Contains(girilenHarf))
            {
                MessageBox.Show("Bu harfi daha önce girmiştiniz!");
                return;
            }
            

            //lstYanlis.Items.Add(girilenHarf);
            bool bulundu = false;

            foreach (var item in pnlHarfler.Controls)
            {
                if (item is TextBox)
                {
                    var txtbx = item as TextBox;
                    if (txtbx.Tag != null && txtbx.Tag.ToString().Equals(girilenHarf))
                    {
                        txtbx.Text = girilenHarf;
                        bulundu = true;
                    }
                }

            }
            lblText = lblText + textBox1.Text + " ";
            lblYanlis.Text = lblText;

            if (!bulundu)
            {
                kullaniciHak++;

            }
            textBox1.Clear();

            bool isEnd = true; 

            if (kullaniciHak > 0)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Pic\" + kullaniciHak.ToString() + kullaniciHak.ToString() + ".PNG");
                if (kullaniciHak == 9)
                {
                    pnlHarfler.BackColor = Color.Red;
                    MessageBox.Show("Malesef,oyunu kaybettiniz.");
                    
                }

            }
            foreach (Control item in pnlHarfler.Controls)
            { 
                if (item is TextBox)

                {
                    var txtbx = item as TextBox;

                    if (item.Text == "_")
                        isEnd = false;
                        
                }
            }
            if(isEnd)
                MessageBox.Show("Tebrikler,Kazandınız!");
                pnlHarfler.BackColor = Color.White;

        }
        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            oyunuBaslat();

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = textBox1.Text.Trim().Length == 1;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("harften farklı karakter girdiniz ,lutfen harf giriniz:");

                }
            }
    
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        /* private void lblYanlis_Click(object sender, EventArgs e)
         {

         }*/
    }
}





    // }
    //}

    // private void textBox1_TextChanged(object sender, EventArgs e)
    //{

    // }

    //private void textBox1_Click(object sender, EventArgs e)
    //{
    //    textBox1.Text = " ";

    //}


    //private void textBox1_TextChanged(object sender, EventArgs e)
    //{

    // }

    // private void label1_Click(object sender, EventArgs e)
    //{

    // }

    //private void label7_Click(object sender, EventArgs e)
    // {

    //}


/*private void button2_Click(object sender, EventArgs e)
{
    string deneme = "ENGİN";
    foreach (var item in deneme.ToCharArray())
    {
        MessageBox.Show(item.ToString());
    }
}

private void textBox1_TextChanged(object sender, EventArgs e)
{

}*/


