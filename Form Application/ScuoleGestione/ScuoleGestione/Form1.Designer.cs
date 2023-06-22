namespace ScuoleGestione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeProgramma = new System.Windows.Forms.Label();
            this.labelTestConnessioneDB = new System.Windows.Forms.Label();
            this.btnVisualizzaRegistro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInserimentoStudente = new System.Windows.Forms.Button();
            this.btnEliminazioneRiga = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeProgramma
            // 
            this.labelNomeProgramma.AutoSize = true;
            this.labelNomeProgramma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNomeProgramma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProgramma.Location = new System.Drawing.Point(12, 9);
            this.labelNomeProgramma.Name = "labelNomeProgramma";
            this.labelNomeProgramma.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.labelNomeProgramma.Size = new System.Drawing.Size(268, 30);
            this.labelNomeProgramma.TabIndex = 0;
            this.labelNomeProgramma.Text = "Gestione Registro Studenti";
            this.labelNomeProgramma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTestConnessioneDB
            // 
            this.labelTestConnessioneDB.AutoSize = true;
            this.labelTestConnessioneDB.Location = new System.Drawing.Point(13, 532);
            this.labelTestConnessioneDB.Name = "labelTestConnessioneDB";
            this.labelTestConnessioneDB.Size = new System.Drawing.Size(141, 13);
            this.labelTestConnessioneDB.TabIndex = 2;
            this.labelTestConnessioneDB.Text = "Test Connessione Database";
            this.labelTestConnessioneDB.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnVisualizzaRegistro
            // 
            this.btnVisualizzaRegistro.Location = new System.Drawing.Point(164, 463);
            this.btnVisualizzaRegistro.Name = "btnVisualizzaRegistro";
            this.btnVisualizzaRegistro.Size = new System.Drawing.Size(147, 23);
            this.btnVisualizzaRegistro.TabIndex = 3;
            this.btnVisualizzaRegistro.Text = "Visualizza Registro Studenti";
            this.btnVisualizzaRegistro.UseVisualStyleBackColor = true;
            this.btnVisualizzaRegistro.Click += new System.EventHandler(this.btnVisualizzaRegistro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(518, 499);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnInserimentoStudente
            // 
            this.btnInserimentoStudente.Location = new System.Drawing.Point(164, 491);
            this.btnInserimentoStudente.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserimentoStudente.Name = "btnInserimentoStudente";
            this.btnInserimentoStudente.Size = new System.Drawing.Size(150, 24);
            this.btnInserimentoStudente.TabIndex = 5;
            this.btnInserimentoStudente.Text = "Inserimento Nuovo Studente";
            this.btnInserimentoStudente.UseVisualStyleBackColor = true;
            // 
            // btnEliminazioneRiga
            // 
            this.btnEliminazioneRiga.Location = new System.Drawing.Point(495, 519);
            this.btnEliminazioneRiga.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminazioneRiga.Name = "btnEliminazioneRiga";
            this.btnEliminazioneRiga.Size = new System.Drawing.Size(96, 24);
            this.btnEliminazioneRiga.TabIndex = 6;
            this.btnEliminazioneRiga.Text = "Elimina riga";
            this.btnEliminazioneRiga.UseVisualStyleBackColor = true;
            this.btnEliminazioneRiga.Click += new System.EventHandler(this.btnEliminazioneRiga_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(413, 519);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(78, 24);
            this.btnCerca.TabIndex = 7;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(13, 97);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 9;
            this.lblCognome.Text = "Cognome";
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Location = new System.Drawing.Point(13, 120);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(50, 13);
            this.lblMatricola.TabIndex = 10;
            this.lblMatricola.Text = "Matricola";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 11;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(72, 97);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 12;
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(72, 124);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(100, 20);
            this.txtMatricola.TabIndex = 13;
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(69, 164);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 14;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(21, 167);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 15;
            this.lblMateria.Text = "Materia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 554);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMatricola);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnEliminazioneRiga);
            this.Controls.Add(this.btnInserimentoStudente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVisualizzaRegistro);
            this.Controls.Add(this.labelTestConnessioneDB);
            this.Controls.Add(this.labelNomeProgramma);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeProgramma;
        private System.Windows.Forms.Label labelTestConnessioneDB;
        private System.Windows.Forms.Button btnVisualizzaRegistro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInserimentoStudente;
        private System.Windows.Forms.Button btnEliminazioneRiga;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblMatricola;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblMateria;
    }
}

