using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Semestrální_projekt
{
    public partial class AddPalet : Form
    {
        internal Paleta ?CreatedPaleta { get; private set; } = null;

        public AddPalet()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string obsah = Content.Text;
            int pocet = (int)Count.Value;
            float hmotnost = (float)Weight.Value;

            string jednotka = Properties.Settings.Default.def_metric;
            if (jednotka == "lb") {
                hmotnost *= 0.453592f;
            }
            else if (jednotka == "g") {
                hmotnost /= 1000f;
            }

            CreatedPaleta = new Paleta(null, obsah, pocet, hmotnost, null);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
