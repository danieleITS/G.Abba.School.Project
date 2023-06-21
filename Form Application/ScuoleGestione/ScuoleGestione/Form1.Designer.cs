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
            this.btnEliminazioneStudente = new System.Windows.Forms.Button();
            this.btnRicercaStudente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.labelTestConnessioneDB.Location = new System.Drawing.Point(18, 69);
            this.labelTestConnessioneDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestConnessioneDB.Name = "labelTestConnessioneDB";
            this.labelTestConnessioneDB.Size = new System.Drawing.Size(179, 16);
            this.labelTestConnessioneDB.TabIndex = 2;
            this.labelTestConnessioneDB.Text = "Test Connessione Database";
            this.labelTestConnessioneDB.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnVisualizzaRegistro
            // 
            this.btnVisualizzaRegistro.Location = new System.Drawing.Point(17, 412);
            this.btnVisualizzaRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizzaRegistro.Name = "btnVisualizzaRegistro";
            this.btnVisualizzaRegistro.Size = new System.Drawing.Size(196, 28);
            this.btnVisualizzaRegistro.TabIndex = 3;
            this.btnVisualizzaRegistro.Text = "Visualizza Registro Studenti";
            this.btnVisualizzaRegistro.UseVisualStyleBackColor = true;
            this.btnVisualizzaRegistro.Click += new System.EventHandler(this.btnVisualizzaRegistro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(691, 656);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnInserimentoStudente
            // 
            this.btnInserimentoStudente.Location = new System.Drawing.Point(17, 447);
            this.btnInserimentoStudente.Name = "btnInserimentoStudente";
            this.btnInserimentoStudente.Size = new System.Drawing.Size(200, 30);
            this.btnInserimentoStudente.TabIndex = 5;
            this.btnInserimentoStudente.Text = "Inserimento Nuovo Studente";
            this.btnInserimentoStudente.UseVisualStyleBackColor = true;
            this.btnInserimentoStudente.Click += new System.EventHandler(this.btnInserimentoStudente_Click);
            // 
            // btnEliminazioneStudente
            // 
            this.btnEliminazioneStudente.Location = new System.Drawing.Point(17, 519);
            this.btnEliminazioneStudente.Name = "btnEliminazioneStudente";
            this.btnEliminazioneStudente.Size = new System.Drawing.Size(200, 30);
            this.btnEliminazioneStudente.TabIndex = 6;
            this.btnEliminazioneStudente.Text = "Eliminazione Studente";
            this.btnEliminazioneStudente.UseVisualStyleBackColor = true;
            this.btnEliminazioneStudente.Click += new System.EventHandler(this.btnEliminazioneStudente_Click);
            // 
            // btnRicercaStudente
            // 
            this.btnRicercaStudente.Location = new System.Drawing.Point(17, 483);
            this.btnRicercaStudente.Name = "btnRicercaStudente";
            this.btnRicercaStudente.Size = new System.Drawing.Size(200, 30);
            this.btnRicercaStudente.TabIndex = 7;
            this.btnRicercaStudente.Text = "Ricerca Studente";
            this.btnRicercaStudente.UseVisualStyleBackColor = true;
            this.btnRicercaStudente.Click += new System.EventHandler(this.btnRicercaStudente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 682);
            this.Controls.Add(this.btnRicercaStudente);
            this.Controls.Add(this.btnEliminazioneStudente);
            this.Controls.Add(this.btnInserimentoStudente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVisualizzaRegistro);
            this.Controls.Add(this.labelTestConnessioneDB);
            this.Controls.Add(this.labelNomeProgramma);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.Button btnEliminazioneStudente;
        private System.Windows.Forms.Button btnRicercaStudente;
    }
}

