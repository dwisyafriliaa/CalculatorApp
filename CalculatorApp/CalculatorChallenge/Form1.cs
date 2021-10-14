using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOperasi.Items.Add("Penambahan");
            cbOperasi.Items.Add("Pengurangan");
            cbOperasi.Items.Add("Perkalian");
            cbOperasi.Items.Add("Pembagian");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            int intHasil;

            intHasil = 0;

            switch (cbOperasi.Text)
            {
                case "Penambahan":
                    intHasil = a + b;

                    break;

                case "Pengurangan":
                    intHasil = a - b;

                    break;

                case "Perkalian":
                    intHasil = a * b;

                    break;

                case "Pembagian":
                    intHasil = a / b;

                    break;
            }

            txtHasil.Text = intHasil.ToString();
        }
    }
}