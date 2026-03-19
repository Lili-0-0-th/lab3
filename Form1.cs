using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;



namespace lab3
{
    public partial class Form1 : Form
    {
        private int nextId = 1;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Imie", "Imię");
            dataGridView1.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("Wiek", "Wiek");
            dataGridView1.Columns.Add("Stanowisko", "Stanowisko");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butdod_Click(object sender, EventArgs e)
        {
            Form2 formDodaj = new Form2();

            if (formDodaj.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(nextId++, formDodaj.Imie, formDodaj.Nazwisko, formDodaj.Wiek, formDodaj.Stanowisko);
            }
        }

        private void butus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć pracownika do usunięcia!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butzapis_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz plik CSV do wczytania";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                string[] headers = new string[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    headers[i] = dataGridView1.Columns[i].HeaderText;
                }
                string csvContent = string.Join(",", headers) + Environment.NewLine;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string[] cells = new string[dataGridView1.Columns.Count];
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            cells[i] = row.Cells[i].Value?.ToString() ?? "";
                        }

                        csvContent += string.Join(",", cells) + Environment.NewLine;
                    }
                }

                File.WriteAllText(saveFileDialog1.FileName, csvContent);
                MessageBox.Show("Dane zostały zapisane pomyślnie!", "Sukces");
            }

        }

        private void butodcz_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                
                dataGridView1.Rows.Clear();
                nextId = 1; 
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);

                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i])) continue;

                    string[] values = lines[i].Split(',');

                    dataGridView1.Rows.Add(values);

                    if (int.TryParse(values[0], out int loadedId))
                    {
                        if (loadedId >= nextId)
                        {
                            nextId = loadedId + 1;
                        }
                    }
                }
                MessageBox.Show("Dane zostały wczytane!", "Sukces");
            }
        }
    }
}
