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
            this.lblNomeProgramma = new System.Windows.Forms.Label();
            this.lblTestConnessioneDB = new System.Windows.Forms.Label();
            this.btnVisualizzaRegistro = new System.Windows.Forms.Button();
            this.dtgrdvw = new System.Windows.Forms.DataGridView();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnVisualizzaClassi = new System.Windows.Forms.Button();
            this.btnVisualizzaMaterie = new System.Windows.Forms.Button();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnVisualizzaStudenti = new System.Windows.Forms.Button();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProgramma
            // 
            this.lblNomeProgramma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNomeProgramma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProgramma.Location = new System.Drawing.Point(20, 20);
            this.lblNomeProgramma.Name = "lblNomeProgramma";
            this.lblNomeProgramma.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblNomeProgramma.Size = new System.Drawing.Size(330, 40);
            this.lblNomeProgramma.TabIndex = 0;
            this.lblNomeProgramma.Text = "Gestione Registro Studenti";
            this.lblNomeProgramma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestConnessioneDB
            // 
            this.lblTestConnessioneDB.AutoSize = true;
            this.lblTestConnessioneDB.Location = new System.Drawing.Point(855, 4);
            this.lblTestConnessioneDB.Name = "lblTestConnessioneDB";
            this.lblTestConnessioneDB.Size = new System.Drawing.Size(141, 13);
            this.lblTestConnessioneDB.TabIndex = 2;
            this.lblTestConnessioneDB.Text = "Test Connessione Database";
            this.lblTestConnessioneDB.Visible = false;
            // 
            // btnVisualizzaRegistro
            // 
            this.btnVisualizzaRegistro.Location = new System.Drawing.Point(191, 70);
            this.btnVisualizzaRegistro.Name = "btnVisualizzaRegistro";
            this.btnVisualizzaRegistro.Size = new System.Drawing.Size(150, 30);
            this.btnVisualizzaRegistro.TabIndex = 3;
            this.btnVisualizzaRegistro.Text = "Visualizza Registro Voti";
            this.btnVisualizzaRegistro.UseVisualStyleBackColor = true;
            this.btnVisualizzaRegistro.Click += new System.EventHandler(this.btnVisualizzaRegistro_Click);
            // 
            // dtgrdvw
            // 
            this.dtgrdvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvw.Location = new System.Drawing.Point(385, 20);
            this.dtgrdvw.Name = "dtgrdvw";
            this.dtgrdvw.RowHeadersWidth = 50;
            this.dtgrdvw.Size = new System.Drawing.Size(600, 480);
            this.dtgrdvw.TabIndex = 4;
            this.dtgrdvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvw_CellContentClick);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(385, 512);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(140, 30);
            this.btnInserisci.TabIndex = 5;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(845, 512);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(2);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(140, 30);
            this.btnElimina.TabIndex = 6;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(538, 512);
            this.btnRicerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(140, 30);
            this.btnRicerca.TabIndex = 7;
            this.btnRicerca.Text = "Ricerca";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(692, 512);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(140, 30);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(138, 388);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 25);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "Cerca";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(30, 319);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Nome";
            this.lbl4.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(30, 349);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(52, 13);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Cognome";
            this.lbl5.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(117, 316);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(222, 20);
            this.txt2.TabIndex = 11;
            this.txt2.Visible = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(117, 346);
            this.txt3.Margin = new System.Windows.Forms.Padding(2);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(222, 20);
            this.txt3.TabIndex = 12;
            this.txt3.Visible = false;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(117, 254);
            this.cmb1.Margin = new System.Windows.Forms.Padding(2);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(222, 21);
            this.cmb1.TabIndex = 14;
            this.cmb1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(30, 257);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 13);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Materia";
            this.lbl2.Visible = false;
            // 
            // btnVisualizzaClassi
            // 
            this.btnVisualizzaClassi.Location = new System.Drawing.Point(35, 106);
            this.btnVisualizzaClassi.Name = "btnVisualizzaClassi";
            this.btnVisualizzaClassi.Size = new System.Drawing.Size(150, 30);
            this.btnVisualizzaClassi.TabIndex = 16;
            this.btnVisualizzaClassi.Text = "Visualizza Classi";
            this.btnVisualizzaClassi.UseVisualStyleBackColor = true;
            this.btnVisualizzaClassi.Click += new System.EventHandler(this.btnVisualizzaClassi_Click);
            // 
            // btnVisualizzaMaterie
            // 
            this.btnVisualizzaMaterie.Location = new System.Drawing.Point(191, 106);
            this.btnVisualizzaMaterie.Name = "btnVisualizzaMaterie";
            this.btnVisualizzaMaterie.Size = new System.Drawing.Size(150, 30);
            this.btnVisualizzaMaterie.TabIndex = 17;
            this.btnVisualizzaMaterie.Text = "Visualizza Materie";
            this.btnVisualizzaMaterie.UseVisualStyleBackColor = true;
            this.btnVisualizzaMaterie.Click += new System.EventHandler(this.btnVisualizzaMaterie_Click);
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl0.Location = new System.Drawing.Point(127, 186);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(132, 22);
            this.lbl0.TabIndex = 18;
            this.lbl0.Text = "Cerca studente";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl0.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(30, 228);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 13);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "Matricola";
            this.lbl1.Visible = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(117, 225);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(222, 20);
            this.txt1.TabIndex = 21;
            this.txt1.Visible = false;
            // 
            // btnVisualizzaStudenti
            // 
            this.btnVisualizzaStudenti.Location = new System.Drawing.Point(35, 70);
            this.btnVisualizzaStudenti.Name = "btnVisualizzaStudenti";
            this.btnVisualizzaStudenti.Size = new System.Drawing.Size(150, 30);
            this.btnVisualizzaStudenti.TabIndex = 38;
            this.btnVisualizzaStudenti.Text = "Visualizza Studenti";
            this.btnVisualizzaStudenti.UseVisualStyleBackColor = true;
            this.btnVisualizzaStudenti.Click += new System.EventHandler(this.btnVisualizzaStudenti_Click);
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(117, 285);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(222, 21);
            this.cmb2.TabIndex = 22;
            this.cmb2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(30, 288);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 13);
            this.lbl3.TabIndex = 23;
            this.lbl3.Text = "Voto";
            this.lbl3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnVisualizzaStudenti);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.btnVisualizzaMaterie);
            this.Controls.Add(this.btnVisualizzaClassi);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.dtgrdvw);
            this.Controls.Add(this.btnVisualizzaRegistro);
            this.Controls.Add(this.lblTestConnessioneDB);
            this.Controls.Add(this.lblNomeProgramma);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProgramma;
        private System.Windows.Forms.Label lblTestConnessioneDB;
        private System.Windows.Forms.Button btnVisualizzaRegistro;
        private System.Windows.Forms.DataGridView dtgrdvw;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnVisualizzaClassi;
        private System.Windows.Forms.Button btnVisualizzaMaterie;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnVisualizzaStudenti;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label lbl3;
    }
}

