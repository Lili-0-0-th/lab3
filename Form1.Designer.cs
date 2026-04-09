namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            butdod = new Button();
            butus = new Button();
            butzapis = new Button();
            butodcz = new Button();
            btnZapisJSON = new Button();
            btnZapisXML = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(560, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // butdod
            // 
            butdod.Location = new Point(638, 135);
            butdod.Name = "butdod";
            butdod.Size = new Size(94, 29);
            butdod.TabIndex = 1;
            butdod.Text = "Dodaj";
            butdod.UseVisualStyleBackColor = true;
            butdod.Click += butdod_Click;
            // 
            // butus
            // 
            butus.Location = new Point(638, 222);
            butus.Name = "butus";
            butus.Size = new Size(94, 29);
            butus.TabIndex = 2;
            butus.Text = "Usuń";
            butus.UseVisualStyleBackColor = true;
            butus.Click += butus_Click;
            // 
            // butzapis
            // 
            butzapis.Location = new Point(205, 379);
            butzapis.Name = "butzapis";
            butzapis.Size = new Size(111, 29);
            butzapis.TabIndex = 3;
            butzapis.Text = "Zapis do .csv";
            butzapis.UseVisualStyleBackColor = true;
            butzapis.Click += butzapis_Click;
            // 
            // butodcz
            // 
            butodcz.Location = new Point(350, 379);
            butodcz.Name = "butodcz";
            butodcz.Size = new Size(111, 29);
            butodcz.TabIndex = 4;
            butodcz.Text = "Odczyt z .csv";
            butodcz.UseVisualStyleBackColor = true;
            butodcz.Click += butodcz_Click;
            // 
            // btnZapisJSON
            // 
            btnZapisJSON.Location = new Point(48, 379);
            btnZapisJSON.Name = "btnZapisJSON";
            btnZapisJSON.Size = new Size(116, 29);
            btnZapisJSON.TabIndex = 6;
            btnZapisJSON.Text = "Zapis do JSON";
            btnZapisJSON.UseVisualStyleBackColor = true;
            btnZapisJSON.Click += btnZapisJSON_Click;
            // 
            // btnZapisXML
            // 
            btnZapisXML.Location = new Point(497, 379);
            btnZapisXML.Name = "btnZapisXML";
            btnZapisXML.Size = new Size(111, 29);
            btnZapisXML.TabIndex = 5;
            btnZapisXML.Text = "Zapis do XML";
            btnZapisXML.UseVisualStyleBackColor = true;
            btnZapisXML.Click += btnZapisXML_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZapisXML);
            Controls.Add(btnZapisJSON);
            Controls.Add(butodcz);
            Controls.Add(butzapis);
            Controls.Add(butus);
            Controls.Add(butdod);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Info pracowniki";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butdod;
        private Button butus;
        private Button butzapis;
        private Button butodcz;
        private Button btnZapisXML;
        private Button btnZapisJSON;
    }
}
