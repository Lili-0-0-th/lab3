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
    }
}
