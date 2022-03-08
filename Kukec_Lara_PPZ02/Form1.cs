using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kukec_Lara_PPZ02
{
    public partial class Form1 : Form
    {
        List<Gazirano> gaziranaPica = new List<Gazirano>();
        List<Negazirano> negaziranaPica=new List<Negazirano>();
        List<Alkoholna> alkoholnaPica=new List<Alkoholna>();

        public Form1()
        {
            InitializeComponent();

            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbGazirano.Checked)
            {
                Gazirano gazirano = new Gazirano(txtNaziv.Text, cmbKolicina.Text, cmbPakiranje.Text, Convert.ToDouble(txtCijena.Text));
                gaziranaPica.Add(gazirano);
            }
            else if (rdbAlkoholno.Checked)
            {
                Alkoholna alkoholna = new Alkoholna(txtNaziv.Text, cmbKolicina.Text, cmbPakiranje.Text,trckPostotak.Value, Convert.ToDouble(txtCijena.Text));
                alkoholnaPica.Add(alkoholna);
            }
            else
            {
                Negazirano negazirano = new Negazirano(txtNaziv.Text, cmbKolicina.Text, cmbPakiranje.Text, Convert.ToDouble(txtCijena.Text));
                negaziranaPica.Add(negazirano);
            }

            MessageBox.Show("Uspješan unos!", "Uspjeh",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trckPostotak_Scroll(object sender, EventArgs e)
        {
            lblPostotak.Text = Convert.ToString(trckPostotak.Value);

        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            rtbIspis.Clear();

            foreach (Gazirano gazirano in gaziranaPica)
            {
                rtbIspis.AppendText(gazirano.ToString());
            }

            foreach (Negazirano negazirano in negaziranaPica)
            {
                rtbIspis.AppendText(negazirano.ToString());

            }

            foreach (Alkoholna alkoholna in alkoholnaPica)
            {
                rtbIspis.AppendText(alkoholna.ToString());

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void rdbGazirano_CheckedChanged(object sender, EventArgs e)
        {
            trckPostotak.Enabled = false;
        }

        private void rdbNegazirano_CheckedChanged(object sender, EventArgs e)
        {
            trckPostotak.Enabled = false;
        }

        private void rdbAlkoholno_CheckedChanged(object sender, EventArgs e)
        {
            trckPostotak.Enabled = true;
        }
    }
}
