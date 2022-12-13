using CookpadForm.models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CookpadForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new CoockpadDBContext())
            {
                var botoaData = db.Botoa
                .Include("Errezeta")
                .Where(b => b.Urtea == comboBoxUrtea.Text)
                .GroupBy(b => b.Errezeta.Izena)
                .ToDictionary(g => g.Key, g => g.Count());
                if (botoaData != null)
                {
                    if (botoaData.Count > 0)
                    {
                        var kontrolak = grafikoaUserControl1.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var kontrola in kontrolak)
                        {
                            kontrola.Titles[0].Text = "Cookpad";
                            kontrola.DataSource = botoaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }

        private void txtZenb_KeyPress(object sender, KeyPressEventArgs e) //Controlar que el usuario no pueda meter letras, solo números.
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Erabiltzailea erabiltzailea = new Erabiltzailea();
                erabiltzailea.Id = txtNan.Text;
                erabiltzailea.Emaila = textBoxEmaila.Text;
                erabiltzailea.Ezizena = txtEzizena.Text;
                erabiltzailea.Izena = txtIzena.Text;

                string bidalita = erabiltzailea.Izena + "zure botoa jaso dugu, eskerrik asko";

                labelMezua.Text = bidalita;



            }
            catch (Exception ex){
                
                MessageBox.Show(ex.Message);
                
            }
        }


    }
}
