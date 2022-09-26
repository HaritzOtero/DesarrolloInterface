namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkuagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }
        private void Balioak()
        {
            try
            {
                kalkuagailua.Zenbaki1 = float.Parse(txtZenbaki1.Text);
                kalkuagailua.Zenbaki2 = float.Parse(txtZenbaki2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea gertatu da: " + ex.Message);
                Application.Exit();
            }

        }

        private void Hasieratu()
        {
            txtZenbaki1.Text = "";
            txtZenbaki2.Text = "";
            txtZenbaki1.Focus();
        }
        private void btnGehi_Click(object sender, EventArgs e)
        {
            Balioak();
            MessageBox.Show(kalkuagailua.Gehiketa().ToString("0.00"));
            Hasieratu();
        }

        private void btnKen_Click(object sender, EventArgs e)
        {
            Balioak();
            MessageBox.Show(kalkuagailua.Kenketa().ToString("0.00"));
            Hasieratu();
        }

        private void btnBider_Click(object sender, EventArgs e)
        {
            Balioak();
            MessageBox.Show(kalkuagailua.Biderketa().ToString("0.00"));
            Hasieratu();
        }

        private void btnZati_Click(object sender, EventArgs e)
        {
            Balioak();
            MessageBox.Show(kalkuagailua.Zatiketa().ToString("0.00"));
            Hasieratu();
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtZenbaki1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (txtZenbaki1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenbaki1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }

        }

        private void txtZenbaki2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (txtZenbaki2.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenbaki2.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
    }
}