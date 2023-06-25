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
            this.dtgrdvw = new System.Windows.Forms.DataGridView();
            this.btnInserisciRiga = new System.Windows.Forms.Button();
            this.btnEliminazioneRiga = new System.Windows.Forms.Button();
            this.btnRicercaStudente = new System.Windows.Forms.Button();
            this.btnModificaRiga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvw)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeProgramma
            // 
            this.labelNomeProgramma.AutoSize = true;
            this.labelNomeProgramma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNomeProgramma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProgramma.Location = new System.Drawing.Point(16, 11);
            this.labelNomeProgramma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeProgramma.Name = "labelNomeProgramma";
            this.labelNomeProgramma.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
            this.labelNomeProgramma.Size = new System.Drawing.Size(323, 37);
            this.labelNomeProgramma.TabIndex = 0;
            this.labelNomeProgramma.Text = "Gestione Registro Studenti";
            this.labelNomeProgramma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTestConnessioneDB
            // 
            this.labelTestConnessioneDB.AutoSize = true;
            this.labelTestConnessioneDB.Location = new System.Drawing.Point(17, 655);
            this.labelTestConnessioneDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestConnessioneDB.Name = "labelTestConnessioneDB";
            this.labelTestConnessioneDB.Size = new System.Drawing.Size(179, 16);
            this.labelTestConnessioneDB.TabIndex = 2;
            this.labelTestConnessioneDB.Text = "Test Connessione Database";
            this.labelTestConnessioneDB.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnVisualizzaRegistro
            // 
            this.btnVisualizzaRegistro.Location = new System.Drawing.Point(219, 570);
            this.btnVisualizzaRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizzaRegistro.Name = "btnVisualizzaRegistro";
            this.btnVisualizzaRegistro.Size = new System.Drawing.Size(196, 28);
            this.btnVisualizzaRegistro.TabIndex = 3;
            this.btnVisualizzaRegistro.Text = "Visualizza Registro Studenti";
            this.btnVisualizzaRegistro.UseVisualStyleBackColor = true;
            this.btnVisualizzaRegistro.Click += new System.EventHandler(this.btnVisualizzaRegistro_Click);
            // 
            // dtgrdvw
            // 
            this.dtgrdvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvw.Location = new System.Drawing.Point(540, 15);
            this.dtgrdvw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgrdvw.Name = "dtgrdvw";
            this.dtgrdvw.RowHeadersWidth = 50;
            this.dtgrdvw.Size = new System.Drawing.Size(700, 615);
            this.dtgrdvw.TabIndex = 4;
            this.dtgrdvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnInserisciRiga
            // 
            this.btnInserisciRiga.Location = new System.Drawing.Point(540, 640);
            this.btnInserisciRiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserisciRiga.Name = "btnInserisciRiga";
            this.btnInserisciRiga.Size = new System.Drawing.Size(150, 30);
            this.btnInserisciRiga.TabIndex = 5;
            this.btnInserisciRiga.Text = "Inserisci Riga";
            this.btnInserisciRiga.UseVisualStyleBackColor = true;
            // 
            // btnEliminazioneRiga
            // 
            this.btnEliminazioneRiga.Location = new System.Drawing.Point(1090, 640);
            this.btnEliminazioneRiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminazioneRiga.Name = "btnEliminazioneRiga";
            this.btnEliminazioneRiga.Size = new System.Drawing.Size(150, 30);
            this.btnEliminazioneRiga.TabIndex = 6;
            this.btnEliminazioneRiga.Text = "Elimina riga";
            this.btnEliminazioneRiga.UseVisualStyleBackColor = true;
            this.btnEliminazioneRiga.Click += new System.EventHandler(this.btnEliminazioneRiga_Click);
            // 
            // btnRicercaStudente
            // 
            this.btnRicercaStudente.Location = new System.Drawing.Point(219, 640);
            this.btnRicercaStudente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRicercaStudente.Name = "btnRicercaStudente";
            this.btnRicercaStudente.Size = new System.Drawing.Size(200, 30);
            this.btnRicercaStudente.TabIndex = 7;
            this.btnRicercaStudente.Text = "Ricerca Studente";
            this.btnRicercaStudente.UseVisualStyleBackColor = true;
            // 
            // btnModificaRiga
            // 
            this.btnModificaRiga.Location = new System.Drawing.Point(825, 640);
            this.btnModificaRiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificaRiga.Name = "btnModificaRiga";
            this.btnModificaRiga.Size = new System.Drawing.Size(150, 30);
            this.btnModificaRiga.TabIndex = 8;
            this.btnModificaRiga.Text = "Modifica Riga";
            this.btnModificaRiga.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 682);
            this.Controls.Add(this.btnModificaRiga);
            this.Controls.Add(this.btnRicercaStudente);
            this.Controls.Add(this.btnEliminazioneRiga);
            this.Controls.Add(this.btnInserisciRiga);
            this.Controls.Add(this.dtgrdvw);
            this.Controls.Add(this.btnVisualizzaRegistro);
            this.Controls.Add(this.labelTestConnessioneDB);
            this.Controls.Add(this.labelNomeProgramma);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeProgramma;
        private System.Windows.Forms.Label labelTestConnessioneDB;
        private System.Windows.Forms.Button btnVisualizzaRegistro;
        private System.Windows.Forms.DataGridView dtgrdvw;
        private System.Windows.Forms.Button btnInserisciRiga;
        private System.Windows.Forms.Button btnEliminazioneRiga;
        private System.Windows.Forms.Button btnRicercaStudente;
        private System.Windows.Forms.Button btnModificaRiga;
    }
}

