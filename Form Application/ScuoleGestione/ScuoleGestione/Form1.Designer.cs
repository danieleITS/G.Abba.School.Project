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
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.cmbxMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnVisualizzaClassi = new System.Windows.Forms.Button();
            this.btnVisualizzaMaterie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProgramma
            // 
            this.lblNomeProgramma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNomeProgramma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProgramma.Location = new System.Drawing.Point(20, 20);
            this.lblNomeProgramma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeProgramma.Name = "lblNomeProgramma";
            this.lblNomeProgramma.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
            this.lblNomeProgramma.Size = new System.Drawing.Size(330, 40);
            this.lblNomeProgramma.TabIndex = 0;
            this.lblNomeProgramma.Text = "Gestione Registro Studenti";
            this.lblNomeProgramma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestConnessioneDB
            // 
            this.lblTestConnessioneDB.AutoSize = true;
            this.lblTestConnessioneDB.Location = new System.Drawing.Point(22, 71);
            this.lblTestConnessioneDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestConnessioneDB.Name = "lblTestConnessioneDB";
            this.lblTestConnessioneDB.Size = new System.Drawing.Size(179, 16);
            this.lblTestConnessioneDB.TabIndex = 2;
            this.lblTestConnessioneDB.Text = "Test Connessione Database";
            this.lblTestConnessioneDB.Click += new System.EventHandler(this.lblTestConnessioneDB_Click);
            // 
            // btnVisualizzaRegistro
            // 
            this.btnVisualizzaRegistro.Location = new System.Drawing.Point(20, 512);
            this.btnVisualizzaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizzaRegistro.Name = "btnVisualizzaRegistro";
            this.btnVisualizzaRegistro.Size = new System.Drawing.Size(200, 30);
            this.btnVisualizzaRegistro.TabIndex = 3;
            this.btnVisualizzaRegistro.Text = "Visualizza Registro Voti";
            this.btnVisualizzaRegistro.UseVisualStyleBackColor = true;
            this.btnVisualizzaRegistro.Click += new System.EventHandler(this.btnVisualizzaRegistro_Click);
            // 
            // dtgrdvw
            // 
            this.dtgrdvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvw.Location = new System.Drawing.Point(385, 20);
            this.dtgrdvw.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdvw.Name = "dtgrdvw";
            this.dtgrdvw.RowHeadersWidth = 50;
            this.dtgrdvw.Size = new System.Drawing.Size(600, 480);
            this.dtgrdvw.TabIndex = 4;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(385, 512);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnElimina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnRicerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnModifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(140, 30);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(142, 299);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 25);
            this.btnCerca.TabIndex = 7;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(40, 150);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(66, 16);
            this.lblCognome.TabIndex = 9;
            this.lblCognome.Text = "Cognome";
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Location = new System.Drawing.Point(40, 200);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(62, 16);
            this.lblMatricola.TabIndex = 10;
            this.lblMatricola.Text = "Matricola";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 11;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(120, 150);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 22);
            this.txtCognome.TabIndex = 12;
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(120, 200);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(100, 22);
            this.txtMatricola.TabIndex = 13;
            // 
            // cmbxMateria
            // 
            this.cmbxMateria.FormattingEnabled = true;
            this.cmbxMateria.Location = new System.Drawing.Point(120, 250);
            this.cmbxMateria.Name = "cmbxMateria";
            this.cmbxMateria.Size = new System.Drawing.Size(121, 24);
            this.cmbxMateria.TabIndex = 14;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(40, 250);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 16);
            this.lblMateria.TabIndex = 15;
            this.lblMateria.Text = "Materia";
            // 
            // btnVisualizzaClassi
            // 
            this.btnVisualizzaClassi.Location = new System.Drawing.Point(20, 472);
            this.btnVisualizzaClassi.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizzaClassi.Name = "btnVisualizzaClassi";
            this.btnVisualizzaClassi.Size = new System.Drawing.Size(200, 30);
            this.btnVisualizzaClassi.TabIndex = 16;
            this.btnVisualizzaClassi.Text = "Visualizza Classi";
            this.btnVisualizzaClassi.UseVisualStyleBackColor = true;
            this.btnVisualizzaClassi.Click += new System.EventHandler(this.btnVisualizzaClassi_Click);
            // 
            // btnVisualizzaMaterie
            // 
            this.btnVisualizzaMaterie.Location = new System.Drawing.Point(20, 432);
            this.btnVisualizzaMaterie.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizzaMaterie.Name = "btnVisualizzaMaterie";
            this.btnVisualizzaMaterie.Size = new System.Drawing.Size(200, 30);
            this.btnVisualizzaMaterie.TabIndex = 17;
            this.btnVisualizzaMaterie.Text = "Visualizza Materie";
            this.btnVisualizzaMaterie.UseVisualStyleBackColor = true;
            this.btnVisualizzaMaterie.Click += new System.EventHandler(this.btnVisualizzaMaterie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.btnVisualizzaMaterie);
            this.Controls.Add(this.btnVisualizzaClassi);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbxMateria);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMatricola);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.dtgrdvw);
            this.Controls.Add(this.btnVisualizzaRegistro);
            this.Controls.Add(this.lblTestConnessioneDB);
            this.Controls.Add(this.lblNomeProgramma);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblMatricola;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.ComboBox cmbxMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnVisualizzaClassi;
        private System.Windows.Forms.Button btnVisualizzaMaterie;
    }
}

