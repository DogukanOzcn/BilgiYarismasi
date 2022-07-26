namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0,dogru=0,yanlis=0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;


            label5.Text = btnB.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnC.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnD.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnA.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = false;
            btnSonraki.Text = "SONRAKİ SORU";
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            soruno++;
            lblSoruNo.Text=soruno.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible=false;

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edildi?";
                btnA.Text = "1914";
                btnB.Text = "1916";
                btnC.Text = "1920";
                btnD.Text = "1923";
                label4.Text = "1923";


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Sivas'ın İlçelerinden değildir?" ;
                btnA.Text = "Kangal";
                btnB.Text = "Erciyes";
                btnC.Text = "Şarkışla";
                btnD.Text = "Zara";
                label4.Text = "Erciyes";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Fenerbahçenin şu anki teknik direktörü kimdir?";
                btnA.Text = "Fatih Terim";
                btnB.Text = "Mircea Lucesu";
                btnC.Text = "Jorge Jesus";
                btnD.Text = "Mustafa Denizli";
                label4.Text = "Jorge Jesus";
                btnSonraki.Text = "SONUÇLAR"; 
            }
            if (soruno==4)
            {
                lblSoruNo.Text = "BİTTİ";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("3 soruda: " + "\n" + "Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }
    }
}