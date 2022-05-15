using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class Logowanie : Form
    {
        private Form1 mainForm = null;
        private string[] files;
        private BankAccount bank_acount;
        string wscierzka;
        public Logowanie()
        {
            InitializeComponent();
            string scierzka = Path.GetTempPath();
            if (File.Exists(scierzka + "konfiguracja.konfig") == false)
            {
                File.WriteAllText(scierzka + "konfiguracja.konfig", "scierzka=C:\\Users\\User\\Desktop\\katalogBank");
            }
            string[] e = File.ReadAllLines(scierzka + "konfiguracja.konfig");
            foreach (var item in e)
            {
               wscierzka = item.Split("=")[1];
            }
            files = Directory.GetFiles(wscierzka);
            ladowanie();
            //foreach (var item in z)
            //{
            //    comboBox1.Items.Add(item);
            //}
        }

        /*
         * app.dir = C:\\Userts\\...
         */
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string[] z = File.ReadAllLines(wscierzka + "\\" + comboBox1.SelectedItem.ToString());
            string haslo = textBox3.Text;
            if (z[0].Split(" ")[1] == "podstawowe")
            {
                bank_acount = new BankAccount();
            }
            else if (z[0].Split(" ")[1] == "premium")
            {
                bank_acount = new BankAccountPremium();
            }
            if (z[1] == haslo)
            {
                Form1 form1 = new Form1(comboBox1.SelectedItem.ToString(), bank_acount, wscierzka);
                if (mainForm == null || (form1 != null && !form1.Visible))
                {
                    form1.Show();
                    mainForm = form1;
                }
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Niepoprawne haslo");
            }
        }

        private void buttonCreateAcount_Click(object sender, EventArgs e)
        {
            string element = comboBox2.SelectedItem.ToString();
            string nazwa = textBox1.Text;
            string haslo = textBox2.Text;
            if (element == "Konto Podstawowe")
            {
                bank_acount = new BankAccount();
                File.WriteAllText(wscierzka+ "\\" + nazwa+".txt","bank: podstawowe"+ "\n" + haslo+"\n");
            }
            else
            {
                bank_acount = new BankAccountPremium();
                File.WriteAllText(wscierzka + "\\" + nazwa + ".txt", "bank: premium"+ "\n" + haslo + "\n");
            }
            comboBox1.Items.Clear();
            ladowanie();
        }

        void ladowanie()
        {
            files = Directory.GetFiles(wscierzka);
            string[] z;
            foreach (string path in files)
            {
                string[] pathArr = path.Split("\\");
                comboBox1.Items.Add(pathArr[pathArr.Length - 1]);
                Console.WriteLine(path);
            }
        }
    }
}
