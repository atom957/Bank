using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class Statystyki : Form
    {
        public Statystyki(Operations operations)
        {
            InitializeComponent();
            List<string> z = operations.bankoper;
            List<string> l = new List<string>();
            int i = 0;
            foreach (string item in z)
            {
                if (i != 0)
                {
                    string[] o = item.Split(" ");
                    string[] row = { o[0] , o[1], o[3] };
                    l.Add(row[1]);
                }
                i++;
            }
            if (l.Count != 0)
            {
                int e = int.Parse(l[0]);
                foreach (var item in l)
                {
                    int f = int.Parse(item);
                    if (f > e)
                    {
                        e = f;
                    }
                }
                labelMax.Text = e.ToString();

                int d = int.Parse(l[0]);
                foreach (var item in l)
                {
                    int f = int.Parse(item);
                    if (f < d)
                    {
                        e = f;
                    }
                }
                labelMinimun.Text = e.ToString();
                int r = 0;
                int c = 0;
                foreach (var item in l)
                {
                    r += int.Parse(item);
                    c += 1;
                }
                int y = r / c;
                labelSrednia.Text = y.ToString();
            }
        }

        private void Statystyki_Load(object sender, EventArgs e)
        {

        }
    }
}
