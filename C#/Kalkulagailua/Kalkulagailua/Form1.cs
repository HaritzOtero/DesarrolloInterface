namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGehi_Click(object sender, EventArgs e)
        {
            Kalkuagailua kalkulagailua = new Kalkuagailua(float.Parse(txtZenbaki1.Text), float.Parse(txtZenbaki2.Text));
            MessageBox.Show(kalkulagailua.Gehiketa().ToString());
        }

        private void btnKen_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txtZenbaki1.Text) - float.Parse(txtZenbaki2.Text)).ToString());
        }

        private void btnBider_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txtZenbaki1.Text) * float.Parse(txtZenbaki2.Text)).ToString());
        }

        private void btnZati_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txtZenbaki1.Text) / float.Parse(txtZenbaki2.Text)).ToString());
        }
    }
}