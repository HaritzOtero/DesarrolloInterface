namespace Ariketa1
{
    public partial class Form1 : Form
    {
        Esaldia esaldia = new Esaldia();
        public Form1()
        {
            InitializeComponent();
            esaldi1.Enabled = true;
            esaldi2.Enabled = false;
            esaldi3.Enabled = false;
            esaldi4.Enabled = false;
            esaldi5.Enabled = false;
            lotu.Enabled = false;
        }
        
        
        private void esaldi1_Click(object sender, EventArgs e)
        {
            esaldia.Hitza = esaldiTxtBox.Text;
            esaldiTxtBox.Text = "";
            esaldi1.Enabled = false;
            esaldi2.Enabled = true;
            esaldi3.Enabled = false;
            esaldi4.Enabled = false;
            esaldi5.Enabled = false;
            lotu.Enabled = false;
        }

        private void esaldi2_Click(object sender, EventArgs e)
        {
            esaldiOsoa = esaldiOsoa + " " + esaldiTxtBox.Text;
            esaldiTxtBox.Text = "";
            esaldi1.Enabled = false;
            esaldi2.Enabled = false;
            esaldi3.Enabled = true;
            esaldi4.Enabled = false;
            esaldi5.Enabled = false;
            lotu.Enabled = false;
        }

        private void esaldi3_Click(object sender, EventArgs e)
        {
            esaldiOsoa = esaldiOsoa + " " + esaldiTxtBox.Text;
            esaldiTxtBox.Text = "";
            esaldi1.Enabled = false;
            esaldi2.Enabled = false;
            esaldi3.Enabled = false;
            esaldi4.Enabled = true;
            esaldi5.Enabled = false;
            lotu.Enabled = false;
        }

        private void esaldi4_Click(object sender, EventArgs e)
        {
            esaldiOsoa = esaldiOsoa + " " + esaldiTxtBox.Text;
            esaldiTxtBox.Text = "";
            esaldi1.Enabled = false;
            esaldi2.Enabled = false;
            esaldi3.Enabled = false;
            esaldi4.Enabled = false;
            esaldi5.Enabled = true;
            lotu.Enabled = false;
        }

        private void esaldi5_Click(object sender, EventArgs e)
        {
            esaldiOsoa = esaldiOsoa + " " + esaldiTxtBox.Text;
            esaldiTxtBox.Text = "";
            esaldi1.Enabled = false;
            esaldi2.Enabled = false;
            esaldi3.Enabled = false;
            esaldi4.Enabled = false;
            esaldi5.Enabled = false;
            lotu.Enabled = true;
        }

        private void lotu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldiOsoa);
        }
    }
}