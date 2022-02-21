using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {

        public Form1(string wplik, BankAccount account , string scieszkaPlik)
        {
            InitializeComponent();
            scieszkaP = scieszkaPlik;
            nplik = wplik;
            bank_acount = account;
            Operations operations = new Operations();
            string[] z = File.ReadAllLines(scieszkaPlik + wplik);
            // inicjowanie back-endu (obiektów)
            if (z[0].Split(" ")[1] == "podstawowe")
            {
                contr.sprawdzanie = true;
                comboBox1.Enabled = false;
                button1.Enabled = false;
                comboBox1.SelectedItem = "Konto Podstawowe";
            }
            else if (z[0].Split(" ")[1] == "premium")
            {
                contr.sprawdzanie = true;
                comboBox1.Enabled = false;
                button1.Enabled = false;
                comboBox1.SelectedItem = "Konto Premium";
            }

            // inicjowanie front-endu
            int i = 0;
            foreach (string item in z)
            {
                if (i != 0)
                {
                    string[] e = item.Split(" ");
                    label1.Text = e[e.Length - 1];
                    string[] row = {e[0]+" "+ e[1],e[2],e[4] };
                    operationsTable.Rows.Add(row);
                    account.balance = double.Parse(label1.Text);
                    operations.add(item);
                }
                i++;
            }
            //string[] row1 = { "1", "2", "3" };
            //string[] row2 = { "4", "5", "6" };
            //string[] row3 = { "7", "8", "9" };
            //operationsTable.Rows.Add(row1);
            //operationsTable.Rows.Add(row2);
            //operationsTable.Rows.Add(row3);
            account.operations = operations;
            statystyki = new Statystyki(operations);
        }
        Statystyki statystyki;
        string scieszkaP;
        string nplik;
        private Logowanie log = null;
        Operations operations = new Operations();
        List<string> bank = new List<string>();
        BankAccount bank_acount;
        // List<BankAccount> bak_accounts;
        Controller2 contr = new Controller2();
        private void saveFile()
        {
            string createText = typeof(BankAccountPremium).IsInstanceOfType(bank_acount) ? "bank: premium\n" : "bank: podstawowe\n";
            foreach (string item in bank_acount.operations.bankoper)
            {
                createText += (item + "\n");
            }
            File.WriteAllText(scieszkaP + "\\" + nplik, createText);
            //File.AppendAllText(scieszkaP + nplik,createText);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wybur(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonWplac_Click(object sender, EventArgs e)
        {
            if (bank_acount != null && comboBox2.SelectedItem != null)
            {
                if (textBox1.Text != "")
                {
                    string element = comboBox2.SelectedItem.ToString();
                    if (element == "kwota")
                    {
                        bank_acount.transfer(int.Parse(textBox1.Text));
                        label1.Text = bank_acount.balance.ToString();
                    }
                    else
                    {
                        bank_acount.tranafer(int.Parse(textBox1.Text));
                        label1.Text = bank_acount.balance.ToString();
                    }
                }
                string[] row = {"wplata", textBox1.Text, bank_acount.balance.ToString() };
                operationsTable.Rows.Add(row);
                saveFile();
            }
            else
            {
                MessageBox.Show("Nie wybrano typu konta");
            }
        }

        private void buttonWyplac_Click(object sender, EventArgs e)
        {
            if (bank_acount != null && comboBox2.SelectedItem != null && bank_acount.balance > 0)
            {
                string element = comboBox2.SelectedItem.ToString();
                if (element == "procent")
                {
                    bank_acount.withdraw(int.Parse(textBox1.Text));
                }
                else
                {
                    bank_acount.withdraw(double.Parse(textBox1.Text));
                }
                label1.Text = bank_acount.balance.ToString();

                string[] row = { "wyplata", textBox1.Text, bank_acount.balance.ToString() };
                operationsTable.Rows.Add(row);
                saveFile();
            }
            else
            {
                MessageBox.Show("za malo srodkow lub brak wybranego konta");
            }
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            if (log == null||(logowanie != null && !logowanie.Visible))
            {
                logowanie.Show();
                log = logowanie;
            }
            this.Visible = false;
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            statystyki.Show();
        }
    }
}
