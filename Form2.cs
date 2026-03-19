using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        public string Imie { get; private set; } = "";
        public string Nazwisko { get; private set; } = "";
        public string Wiek { get; private set; } = "";
        public string Stanowisko { get; private set; } = "";

        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Junior");
            comboBox1.Items.Add("Senior");
            comboBox1.Items.Add("Kierownik projektu");

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void butzatw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola!");
                return;
            }

            Imie = textBox1.Text;
            Nazwisko = textBox2.Text;
            Wiek = textBox3.Text;
            Stanowisko = comboBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butanul_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
