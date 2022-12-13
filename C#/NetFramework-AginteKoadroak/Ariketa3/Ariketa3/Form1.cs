namespace Ariketa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (radioButtonKontaktua.Checked)
            {
                KontaktuaSortu();
            }
            else
            {
                if (radioButtonBezeroa.Checked)
                {
                    BezeroaSortu();
                }
                else
                {
                    LangileaSortu();
                }
            }
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KontaktuaSortu()
        {
            try
            {
                Kontaktua kontaktua = new Kontaktua();
                kontaktua.izena = textBoxIzena.Text;
                kontaktua.abizena = textBoxAbizena.Text;
                kontaktua.nan = textBoxNan.Text;
                kontaktua.emaila = textBoxEmail.Text;
                MessageBox.Show(kontaktua.Gorde());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void BezeroaSortu()
        {
            try
            {
                Bezeroa bezeroa = new Bezeroa();
                bezeroa.izena = textBoxIzena.Text;
                bezeroa.abizena = textBoxAbizena.Text;
                bezeroa.nan = textBoxNan.Text;
                bezeroa.emaila = textBoxEmail.Text;
                bezeroa.kategoria = cmbKategoria.Text;
                MessageBox.Show(bezeroa.Gorde());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LangileaSortu()
        {
            try
            {
                Langilea langilea = new Langilea();
                langilea.izena = textBoxIzena.Text;
                langilea.abizena = textBoxAbizena.Text;
                langilea.nan = textBoxNan.Text;
                langilea.emaila = textBoxEmail.Text;
                langilea.soldata = float.Parse(textBoxSoldata.Text);
                langilea.segurtasunSoziala = textBoxSegurtasunSoziala.Text;
                MessageBox.Show(langilea.Gorde());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}