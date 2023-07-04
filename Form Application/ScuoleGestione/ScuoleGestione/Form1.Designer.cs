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
            this.btnCercaCercaStudente = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnVisualizzaClassi = new System.Windows.Forms.Button();
            this.btnVisualizzaMaterie = new System.Windows.Forms.Button();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnVisualizzaStudenti = new System.Windows.Forms.Button();
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
            this.lblTestConnessioneDB.Location = new System.Drawing.Point(0, 7);
            this.lblTestConnessioneDB.Name = "lblTestConnessioneDB";
            this.lblTestConnessioneDB.Size = new System.Drawing.Size(141, 13);
            this.lblTestConnessioneDB.TabIndex = 2;
            this.lblTestConnessioneDB.Text = "Test Connessione Database";
            this.lblTestConnessioneDB.Click += new System.EventHandler(this.lblTestConnessioneDB_Click);
            // 
            // btnVisualizzaRegistro
            // 
            this.btnVisualizzaRegistro.Location = new System.Drawing.Point(189, 69);
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
            // btnCercaCercaStudente
            // 
            this.btnCercaCercaStudente.Location = new System.Drawing.Point(127, 398);
            this.btnCercaCercaStudente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCercaCercaStudente.Name = "btnCercaCercaStudente";
            this.btnCercaCercaStudente.Size = new System.Drawing.Size(56, 20);
            this.btnCercaCercaStudente.TabIndex = 7;
            this.btnCercaCercaStudente.Text = "Cerca";
            this.btnCercaCercaStudente.UseVisualStyleBackColor = true;
            this.btnCercaCercaStudente.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(82, 341);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Nome";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(84, 369);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(52, 13);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Cognome";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(142, 341);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(76, 20);
            this.txt2.TabIndex = 11;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(144, 369);
            this.txt3.Margin = new System.Windows.Forms.Padding(2);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(76, 20);
            this.txt3.TabIndex = 12;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(144, 280);
            this.cmb1.Margin = new System.Windows.Forms.Padding(2);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(92, 21);
            this.cmb1.TabIndex = 14;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(84, 280);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 13);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Materia";
            // 
            // btnVisualizzaClassi
            // 
            this.btnVisualizzaClassi.Location = new System.Drawing.Point(33, 105);
            this.btnVisualizzaClassi.Name = "btnVisualizzaClassi";
            this.btnVisualizzaClassi.Size = new System.Drawing.Size(150, 30);
            this.btnVisualizzaClassi.TabIndex = 16;
            this.btnVisualizzaClassi.Text = "Visualizza Classi";
            this.btnVisualizzaClassi.UseVisualStyleBackColor = true;
            this.btnVisualizzaClassi.Click += new System.EventHandler(this.btnVisualizzaClassi_Click);
            // 
            // btnVisualizzaMaterie
            // 
            this.btnVisualizzaMaterie.Location = new System.Drawing.Point(189, 105);
            this.btnVisualizzaMaterie.Name = "btnVisualizzaMaterie";
            this.btnVisualizzaMaterie.Size = new System.Drawing.Size(150, 30);
            this.btnVisualizzaMaterie.TabIndex = 17;
            this.btnVisualizzaMaterie.Text = "Visualizza Materie";
            this.btnVisualizzaMaterie.UseVisualStyleBackColor = true;
            this.btnVisualizzaMaterie.Click += new System.EventHandler(this.btnVisualizzaMaterie_Click);
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(127, 239);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(79, 13);
            this.lblTitolo.TabIndex = 18;
            this.lblTitolo.Text = "Cerca studente";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(88, 258);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 13);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "Matricola";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(144, 255);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 21;
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "10",
            "10-",
            "9½",
            "9+",
            "9",
            "9-",
            "8½",
            "8+",
            "8",
            "8-",
            "7½",
            "7+",
            "7",
            "7-",
            "6½",
            "6+",
            "6",
            "6-",
            "5½",
            "5+",
            "5",
            "5-",
            "4½",
            "4+",
            "4",
            "4-",
            "3½",
            "3+",
            "3",
            "3-",
            "2½",
            "2+",
            "2",
            "2-",
            "1½",
            "1+",
            "1"});
            this.cmb2.Location = new System.Drawing.Point(123, 306);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 21);
            this.cmb2.TabIndex = 22;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(78, 309);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 13);
            this.lbl3.TabIndex = 23;
            this.lbl3.Text = "Voto";
            // 
            // btnVisualizzaStudenti
            // 
            this.btnVisualizzaStudenti.Location = new System.Drawing.Point(33, 69);
            this.btnVisualizzaStudenti.Name = "btnVisualizzaStudenti";
            this.btnVisualizzaStudenti.Size = new System.Drawing.Size(150, 30);
            this.btnVisualizzaStudenti.TabIndex = 38;
            this.btnVisualizzaStudenti.Text = "Visualizza Studenti";
            this.btnVisualizzaStudenti.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.btnVisualizzaMaterie);
            this.Controls.Add(this.btnVisualizzaClassi);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnCercaCercaStudente);
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
        private System.Windows.Forms.Button btnCercaCercaStudente;
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
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnVisualizzaStudenti;
    }
}

