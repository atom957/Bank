using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class Lokaty : Form
    {
        public Lokaty()
        {
            InitializeComponent();
        }
        Lokata lokat = new Lokata();

        private void Lokaty_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Lokata l = new Lokata();
            l.dataPoczatkowa = DateTime.Now;
            l.kwota = 0.0; // Z UI
            l.dataBiezaca = DateTime.Now;
            if (comboBox1.SelectedItem.ToString() == "noraml")
            {
                l.typLokaty = Lokata.TypLokaty.NORMAL;
            }
            else
            {
                l.typLokaty = Lokata.TypLokaty.PROGRESS;
            }
        }

        public double procent(double kwota, double procent)
        {
            double s = (procent / 100.0) * kwota;
            double m = Math.Round(s, 2);
            return kwota + m;
        }
    }
}
