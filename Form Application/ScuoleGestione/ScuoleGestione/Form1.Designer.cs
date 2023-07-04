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
            this.lblNomeCercaStudente = new System.Windows.Forms.Label();
            this.lblCognomeCercaStudente = new System.Windows.Forms.Label();
            this.txtNomeCercaStudente = new System.Windows.Forms.TextBox();
            this.txtCognomeCercaStudente = new System.Windows.Forms.TextBox();
            this.cmbMateriaAggiungiVoto = new System.Windows.Forms.ComboBox();
            this.lblMateriaAggiungiVoto = new System.Windows.Forms.Label();
            this.btnVisualizzaClassi = new System.Windows.Forms.Button();
            this.btnVisualizzaMaterie = new System.Windows.Forms.Button();
            this.lblCercaStudente = new System.Windows.Forms.Label();
            this.lblMatricolaAggiungiVoto = new System.Windows.Forms.Label();
            this.txtMatricolaAggiungiVoto = new System.Windows.Forms.TextBox();
            this.cmbVotoAggiungiVoto = new System.Windows.Forms.ComboBox();
            this.lblVotoAggiungiVoto = new System.Windows.Forms.Label();
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
            // lblNomeCercaStudente
            // 
            this.lblNomeCercaStudente.AutoSize = true;
            this.lblNomeCercaStudente.Location = new System.Drawing.Point(82, 341);
            this.lblNomeCercaStudente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCercaStudente.Name = "lblNomeCercaStudente";
            this.lblNomeCercaStudente.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCercaStudente.TabIndex = 8;
            this.lblNomeCercaStudente.Text = "Nome";
            // 
            // lblCognomeCercaStudente
            // 
            this.lblCognomeCercaStudente.AutoSize = true;
            this.lblCognomeCercaStudente.Location = new System.Drawing.Point(84, 369);
            this.lblCognomeCercaStudente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCognomeCercaStudente.Name = "lblCognomeCercaStudente";
            this.lblCognomeCercaStudente.Size = new System.Drawing.Size(52, 13);
            this.lblCognomeCercaStudente.TabIndex = 9;
            this.lblCognomeCercaStudente.Text = "Cognome";
            // 
            // txtNomeCercaStudente
            // 
            this.txtNomeCercaStudente.Location = new System.Drawing.Point(142, 341);
            this.txtNomeCercaStudente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCercaStudente.Name = "txtNomeCercaStudente";
            this.txtNomeCercaStudente.Size = new System.Drawing.Size(76, 20);
            this.txtNomeCercaStudente.TabIndex = 11;
            // 
            // txtCognomeCercaStudente
            // 
            this.txtCognomeCercaStudente.Location = new System.Drawing.Point(144, 369);
            this.txtCognomeCercaStudente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCognomeCercaStudente.Name = "txtCognomeCercaStudente";
            this.txtCognomeCercaStudente.Size = new System.Drawing.Size(76, 20);
            this.txtCognomeCercaStudente.TabIndex = 12;
            // 
            // cmbMateriaAggiungiVoto
            // 
            this.cmbMateriaAggiungiVoto.FormattingEnabled = true;
            this.cmbMateriaAggiungiVoto.Location = new System.Drawing.Point(144, 280);
            this.cmbMateriaAggiungiVoto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMateriaAggiungiVoto.Name = "cmbMateriaAggiungiVoto";
            this.cmbMateriaAggiungiVoto.Size = new System.Drawing.Size(92, 21);
            this.cmbMateriaAggiungiVoto.TabIndex = 14;
            // 
            // lblMateriaAggiungiVoto
            // 
            this.lblMateriaAggiungiVoto.AutoSize = true;
            this.lblMateriaAggiungiVoto.Location = new System.Drawing.Point(84, 280);
            this.lblMateriaAggiungiVoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriaAggiungiVoto.Name = "lblMateriaAggiungiVoto";
            this.lblMateriaAggiungiVoto.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaAggiungiVoto.TabIndex = 15;
            this.lblMateriaAggiungiVoto.Text = "Materia";
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
            // lblCercaStudente
            // 
            this.lblCercaStudente.AutoSize = true;
            this.lblCercaStudente.Location = new System.Drawing.Point(127, 239);
            this.lblCercaStudente.Name = "lblCercaStudente";
            this.lblCercaStudente.Size = new System.Drawing.Size(79, 13);
            this.lblCercaStudente.TabIndex = 18;
            this.lblCercaStudente.Text = "Cerca studente";
            this.lblCercaStudente.Click += new System.EventHandler(this.lblCercaStudente_Click);
            // 
            // lblMatricolaAggiungiVoto
            // 
            this.lblMatricolaAggiungiVoto.AutoSize = true;
            this.lblMatricolaAggiungiVoto.Location = new System.Drawing.Point(88, 258);
            this.lblMatricolaAggiungiVoto.Name = "lblMatricolaAggiungiVoto";
            this.lblMatricolaAggiungiVoto.Size = new System.Drawing.Size(50, 13);
            this.lblMatricolaAggiungiVoto.TabIndex = 20;
            this.lblMatricolaAggiungiVoto.Text = "Matricola";
            // 
            // txtMatricolaAggiungiVoto
            // 
            this.txtMatricolaAggiungiVoto.Location = new System.Drawing.Point(144, 255);
            this.txtMatricolaAggiungiVoto.Name = "txtMatricolaAggiungiVoto";
            this.txtMatricolaAggiungiVoto.Size = new System.Drawing.Size(100, 20);
            this.txtMatricolaAggiungiVoto.TabIndex = 21;
            // 
            // cmbVotoAggiungiVoto
            // 
            this.cmbVotoAggiungiVoto.FormattingEnabled = true;
            this.cmbVotoAggiungiVoto.Items.AddRange(new object[] {
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
            this.cmbVotoAggiungiVoto.Location = new System.Drawing.Point(123, 306);
            this.cmbVotoAggiungiVoto.Name = "cmbVotoAggiungiVoto";
            this.cmbVotoAggiungiVoto.Size = new System.Drawing.Size(121, 21);
            this.cmbVotoAggiungiVoto.TabIndex = 22;
            // 
            // lblVotoAggiungiVoto
            // 
            this.lblVotoAggiungiVoto.AutoSize = true;
            this.lblVotoAggiungiVoto.Location = new System.Drawing.Point(78, 309);
            this.lblVotoAggiungiVoto.Name = "lblVotoAggiungiVoto";
            this.lblVotoAggiungiVoto.Size = new System.Drawing.Size(29, 13);
            this.lblVotoAggiungiVoto.TabIndex = 23;
            this.lblVotoAggiungiVoto.Text = "Voto";
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
            this.Controls.Add(this.lblVotoAggiungiVoto);
            this.Controls.Add(this.cmbVotoAggiungiVoto);
            this.Controls.Add(this.txtMatricolaAggiungiVoto);
            this.Controls.Add(this.lblMatricolaAggiungiVoto);
            this.Controls.Add(this.lblCercaStudente);
            this.Controls.Add(this.btnVisualizzaMaterie);
            this.Controls.Add(this.btnVisualizzaClassi);
            this.Controls.Add(this.lblMateriaAggiungiVoto);
            this.Controls.Add(this.cmbMateriaAggiungiVoto);
            this.Controls.Add(this.txtCognomeCercaStudente);
            this.Controls.Add(this.txtNomeCercaStudente);
            this.Controls.Add(this.lblCognomeCercaStudente);
            this.Controls.Add(this.lblNomeCercaStudente);
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
        private System.Windows.Forms.Label lblNomeCercaStudente;
        private System.Windows.Forms.Label lblCognomeCercaStudente;
        private System.Windows.Forms.TextBox txtNomeCercaStudente;
        private System.Windows.Forms.TextBox txtCognomeCercaStudente;
        private System.Windows.Forms.ComboBox cmbMateriaAggiungiVoto;
        private System.Windows.Forms.Label lblMateriaAggiungiVoto;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnVisualizzaClassi;
        private System.Windows.Forms.Button btnVisualizzaMaterie;
        private System.Windows.Forms.Label lblCercaStudente;
        private System.Windows.Forms.Label lblMatricolaAggiungiVoto;
        private System.Windows.Forms.TextBox txtMatricolaAggiungiVoto;
        private System.Windows.Forms.ComboBox cmbVotoAggiungiVoto;
        private System.Windows.Forms.Label lblVotoAggiungiVoto;
        private System.Windows.Forms.Button btnVisualizzaStudenti;
    }
}

