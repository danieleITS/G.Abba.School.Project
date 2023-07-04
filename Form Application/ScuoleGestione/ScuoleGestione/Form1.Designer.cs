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
            this.lblMatricolaCercaStudente = new System.Windows.Forms.Label();
            this.txtNomeCercaStudente = new System.Windows.Forms.TextBox();
            this.txtCognomeCercaStudente = new System.Windows.Forms.TextBox();
            this.txtMatricolaCercaStudente = new System.Windows.Forms.TextBox();
            this.cmbMateriaAggiungiVoto = new System.Windows.Forms.ComboBox();
            this.lblMateriaAggiungiVoto = new System.Windows.Forms.Label();
            this.btnVisualizzaClassi = new System.Windows.Forms.Button();
            this.btnVisualizzaMaterie = new System.Windows.Forms.Button();
            this.lblCercaStudente = new System.Windows.Forms.Label();
            this.lblAggiungiVoto = new System.Windows.Forms.Label();
            this.lblMatricolaAggiungiVoto = new System.Windows.Forms.Label();
            this.txtMatricolaAggiungiVoto = new System.Windows.Forms.TextBox();
            this.cmbVotoAggiungiVoto = new System.Windows.Forms.ComboBox();
            this.lblVotoAggiungiVoto = new System.Windows.Forms.Label();
            this.btnAggiungiAggiungiVoto = new System.Windows.Forms.Button();
            this.lblInserisciStudente = new System.Windows.Forms.Label();
            this.lblNomeInserisciStudente = new System.Windows.Forms.Label();
            this.lblCognomeInserisciStudente = new System.Windows.Forms.Label();
            this.lblClasseInserisciStudente = new System.Windows.Forms.Label();
            this.lblMatricolaInserisciStudente = new System.Windows.Forms.Label();
            this.txtNomeInserisciStudente = new System.Windows.Forms.TextBox();
            this.txtCognomeInserisciStudente = new System.Windows.Forms.TextBox();
            this.cmbClasseInserisciStudente = new System.Windows.Forms.ComboBox();
            this.txtMatricolaInserisciStudente = new System.Windows.Forms.TextBox();
            this.btnInserisciInserisciStudente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProgramma
            // 
            this.lblNomeProgramma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNomeProgramma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProgramma.Location = new System.Drawing.Point(15, 16);
            this.lblNomeProgramma.Name = "lblNomeProgramma";
            this.lblNomeProgramma.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblNomeProgramma.Size = new System.Drawing.Size(248, 32);
            this.lblNomeProgramma.TabIndex = 0;
            this.lblNomeProgramma.Text = "Gestione Registro Studenti";
            this.lblNomeProgramma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestConnessioneDB
            // 
            this.lblTestConnessioneDB.AutoSize = true;
            this.lblTestConnessioneDB.Location = new System.Drawing.Point(16, 58);
            this.lblTestConnessioneDB.Name = "lblTestConnessioneDB";
            this.lblTestConnessioneDB.Size = new System.Drawing.Size(141, 13);
            this.lblTestConnessioneDB.TabIndex = 2;
            this.lblTestConnessioneDB.Text = "Test Connessione Database";
            this.lblTestConnessioneDB.Click += new System.EventHandler(this.lblTestConnessioneDB_Click);
            // 
            // btnVisualizzaRegistro
            // 
            this.btnVisualizzaRegistro.Location = new System.Drawing.Point(12, 555);
            this.btnVisualizzaRegistro.Name = "btnVisualizzaRegistro";
            this.btnVisualizzaRegistro.Size = new System.Drawing.Size(150, 24);
            this.btnVisualizzaRegistro.TabIndex = 3;
            this.btnVisualizzaRegistro.Text = "Visualizza Registro Voti";
            this.btnVisualizzaRegistro.UseVisualStyleBackColor = true;
            this.btnVisualizzaRegistro.Click += new System.EventHandler(this.btnVisualizzaRegistro_Click);
            // 
            // dtgrdvw
            // 
            this.dtgrdvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvw.Location = new System.Drawing.Point(599, 16);
            this.dtgrdvw.Name = "dtgrdvw";
            this.dtgrdvw.RowHeadersWidth = 50;
            this.dtgrdvw.Size = new System.Drawing.Size(538, 531);
            this.dtgrdvw.TabIndex = 4;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(52, 460);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(105, 24);
            this.btnInserisci.TabIndex = 5;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(1032, 557);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(2);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(105, 24);
            this.btnElimina.TabIndex = 6;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(167, 460);
            this.btnRicerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(105, 24);
            this.btnRicerca.TabIndex = 7;
            this.btnRicerca.Text = "Ricerca";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(282, 460);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(105, 24);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCercaCercaStudente
            // 
            this.btnCercaCercaStudente.Location = new System.Drawing.Point(68, 201);
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
            this.lblNomeCercaStudente.Location = new System.Drawing.Point(31, 121);
            this.lblNomeCercaStudente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCercaStudente.Name = "lblNomeCercaStudente";
            this.lblNomeCercaStudente.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCercaStudente.TabIndex = 8;
            this.lblNomeCercaStudente.Text = "Nome";
            // 
            // lblCognomeCercaStudente
            // 
            this.lblCognomeCercaStudente.AutoSize = true;
            this.lblCognomeCercaStudente.Location = new System.Drawing.Point(31, 143);
            this.lblCognomeCercaStudente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCognomeCercaStudente.Name = "lblCognomeCercaStudente";
            this.lblCognomeCercaStudente.Size = new System.Drawing.Size(52, 13);
            this.lblCognomeCercaStudente.TabIndex = 9;
            this.lblCognomeCercaStudente.Text = "Cognome";
            // 
            // lblMatricolaCercaStudente
            // 
            this.lblMatricolaCercaStudente.AutoSize = true;
            this.lblMatricolaCercaStudente.Location = new System.Drawing.Point(31, 166);
            this.lblMatricolaCercaStudente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatricolaCercaStudente.Name = "lblMatricolaCercaStudente";
            this.lblMatricolaCercaStudente.Size = new System.Drawing.Size(50, 13);
            this.lblMatricolaCercaStudente.TabIndex = 10;
            this.lblMatricolaCercaStudente.Text = "Matricola";
            // 
            // txtNomeCercaStudente
            // 
            this.txtNomeCercaStudente.Location = new System.Drawing.Point(91, 121);
            this.txtNomeCercaStudente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCercaStudente.Name = "txtNomeCercaStudente";
            this.txtNomeCercaStudente.Size = new System.Drawing.Size(76, 20);
            this.txtNomeCercaStudente.TabIndex = 11;
            // 
            // txtCognomeCercaStudente
            // 
            this.txtCognomeCercaStudente.Location = new System.Drawing.Point(91, 143);
            this.txtCognomeCercaStudente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCognomeCercaStudente.Name = "txtCognomeCercaStudente";
            this.txtCognomeCercaStudente.Size = new System.Drawing.Size(76, 20);
            this.txtCognomeCercaStudente.TabIndex = 12;
            // 
            // txtMatricolaCercaStudente
            // 
            this.txtMatricolaCercaStudente.Location = new System.Drawing.Point(91, 166);
            this.txtMatricolaCercaStudente.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricolaCercaStudente.Name = "txtMatricolaCercaStudente";
            this.txtMatricolaCercaStudente.Size = new System.Drawing.Size(76, 20);
            this.txtMatricolaCercaStudente.TabIndex = 13;
            // 
            // cmbMateriaAggiungiVoto
            // 
            this.cmbMateriaAggiungiVoto.FormattingEnabled = true;
            this.cmbMateriaAggiungiVoto.Location = new System.Drawing.Point(353, 169);
            this.cmbMateriaAggiungiVoto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMateriaAggiungiVoto.Name = "cmbMateriaAggiungiVoto";
            this.cmbMateriaAggiungiVoto.Size = new System.Drawing.Size(92, 21);
            this.cmbMateriaAggiungiVoto.TabIndex = 14;
            // 
            // lblMateriaAggiungiVoto
            // 
            this.lblMateriaAggiungiVoto.AutoSize = true;
            this.lblMateriaAggiungiVoto.Location = new System.Drawing.Point(293, 169);
            this.lblMateriaAggiungiVoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriaAggiungiVoto.Name = "lblMateriaAggiungiVoto";
            this.lblMateriaAggiungiVoto.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaAggiungiVoto.TabIndex = 15;
            this.lblMateriaAggiungiVoto.Text = "Materia";
            // 
            // btnVisualizzaClassi
            // 
            this.btnVisualizzaClassi.Location = new System.Drawing.Point(12, 523);
            this.btnVisualizzaClassi.Name = "btnVisualizzaClassi";
            this.btnVisualizzaClassi.Size = new System.Drawing.Size(150, 24);
            this.btnVisualizzaClassi.TabIndex = 16;
            this.btnVisualizzaClassi.Text = "Visualizza Classi";
            this.btnVisualizzaClassi.UseVisualStyleBackColor = true;
            this.btnVisualizzaClassi.Click += new System.EventHandler(this.btnVisualizzaClassi_Click);
            // 
            // btnVisualizzaMaterie
            // 
            this.btnVisualizzaMaterie.Location = new System.Drawing.Point(12, 490);
            this.btnVisualizzaMaterie.Name = "btnVisualizzaMaterie";
            this.btnVisualizzaMaterie.Size = new System.Drawing.Size(150, 24);
            this.btnVisualizzaMaterie.TabIndex = 17;
            this.btnVisualizzaMaterie.Text = "Visualizza Materie";
            this.btnVisualizzaMaterie.UseVisualStyleBackColor = true;
            this.btnVisualizzaMaterie.Click += new System.EventHandler(this.btnVisualizzaMaterie_Click);
            // 
            // lblCercaStudente
            // 
            this.lblCercaStudente.AutoSize = true;
            this.lblCercaStudente.Location = new System.Drawing.Point(65, 93);
            this.lblCercaStudente.Name = "lblCercaStudente";
            this.lblCercaStudente.Size = new System.Drawing.Size(79, 13);
            this.lblCercaStudente.TabIndex = 18;
            this.lblCercaStudente.Text = "Cerca studente";
            this.lblCercaStudente.Click += new System.EventHandler(this.lblCercaStudente_Click);
            // 
            // lblAggiungiVoto
            // 
            this.lblAggiungiVoto.AutoSize = true;
            this.lblAggiungiVoto.Location = new System.Drawing.Point(350, 93);
            this.lblAggiungiVoto.Name = "lblAggiungiVoto";
            this.lblAggiungiVoto.Size = new System.Drawing.Size(72, 13);
            this.lblAggiungiVoto.TabIndex = 19;
            this.lblAggiungiVoto.Text = "Aggiungi voto";
            this.lblAggiungiVoto.Click += new System.EventHandler(this.lblAggiungiVoto_Click);
            // 
            // lblMatricolaAggiungiVoto
            // 
            this.lblMatricolaAggiungiVoto.AutoSize = true;
            this.lblMatricolaAggiungiVoto.Location = new System.Drawing.Point(297, 120);
            this.lblMatricolaAggiungiVoto.Name = "lblMatricolaAggiungiVoto";
            this.lblMatricolaAggiungiVoto.Size = new System.Drawing.Size(50, 13);
            this.lblMatricolaAggiungiVoto.TabIndex = 20;
            this.lblMatricolaAggiungiVoto.Text = "Matricola";
            // 
            // txtMatricolaAggiungiVoto
            // 
            this.txtMatricolaAggiungiVoto.Location = new System.Drawing.Point(353, 117);
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
            this.cmbVotoAggiungiVoto.Location = new System.Drawing.Point(353, 143);
            this.cmbVotoAggiungiVoto.Name = "cmbVotoAggiungiVoto";
            this.cmbVotoAggiungiVoto.Size = new System.Drawing.Size(121, 21);
            this.cmbVotoAggiungiVoto.TabIndex = 22;
            // 
            // lblVotoAggiungiVoto
            // 
            this.lblVotoAggiungiVoto.AutoSize = true;
            this.lblVotoAggiungiVoto.Location = new System.Drawing.Point(308, 146);
            this.lblVotoAggiungiVoto.Name = "lblVotoAggiungiVoto";
            this.lblVotoAggiungiVoto.Size = new System.Drawing.Size(29, 13);
            this.lblVotoAggiungiVoto.TabIndex = 23;
            this.lblVotoAggiungiVoto.Text = "Voto";
            // 
            // btnAggiungiAggiungiVoto
            // 
            this.btnAggiungiAggiungiVoto.Location = new System.Drawing.Point(370, 198);
            this.btnAggiungiAggiungiVoto.Name = "btnAggiungiAggiungiVoto";
            this.btnAggiungiAggiungiVoto.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungiAggiungiVoto.TabIndex = 24;
            this.btnAggiungiAggiungiVoto.Text = "Aggiungi";
            this.btnAggiungiAggiungiVoto.UseVisualStyleBackColor = true;
            this.btnAggiungiAggiungiVoto.Click += new System.EventHandler(this.btnAggiungiVoto_Click);
            // 
            // lblInserisciStudente
            // 
            this.lblInserisciStudente.AutoSize = true;
            this.lblInserisciStudente.Location = new System.Drawing.Point(65, 245);
            this.lblInserisciStudente.Name = "lblInserisciStudente";
            this.lblInserisciStudente.Size = new System.Drawing.Size(89, 13);
            this.lblInserisciStudente.TabIndex = 25;
            this.lblInserisciStudente.Text = "Inserisci studente";
            this.lblInserisciStudente.Click += new System.EventHandler(this.lblInserisciStudente_Click);
            // 
            // lblNomeInserisciStudente
            // 
            this.lblNomeInserisciStudente.AutoSize = true;
            this.lblNomeInserisciStudente.Location = new System.Drawing.Point(34, 273);
            this.lblNomeInserisciStudente.Name = "lblNomeInserisciStudente";
            this.lblNomeInserisciStudente.Size = new System.Drawing.Size(35, 13);
            this.lblNomeInserisciStudente.TabIndex = 26;
            this.lblNomeInserisciStudente.Text = "Nome";
            // 
            // lblCognomeInserisciStudente
            // 
            this.lblCognomeInserisciStudente.AutoSize = true;
            this.lblCognomeInserisciStudente.Location = new System.Drawing.Point(34, 302);
            this.lblCognomeInserisciStudente.Name = "lblCognomeInserisciStudente";
            this.lblCognomeInserisciStudente.Size = new System.Drawing.Size(52, 13);
            this.lblCognomeInserisciStudente.TabIndex = 27;
            this.lblCognomeInserisciStudente.Text = "Cognome";
            // 
            // lblClasseInserisciStudente
            // 
            this.lblClasseInserisciStudente.AutoSize = true;
            this.lblClasseInserisciStudente.Location = new System.Drawing.Point(37, 338);
            this.lblClasseInserisciStudente.Name = "lblClasseInserisciStudente";
            this.lblClasseInserisciStudente.Size = new System.Drawing.Size(32, 13);
            this.lblClasseInserisciStudente.TabIndex = 29;
            this.lblClasseInserisciStudente.Text = "Anno";
            // 
            // lblMatricolaInserisciStudente
            // 
            this.lblMatricolaInserisciStudente.AutoSize = true;
            this.lblMatricolaInserisciStudente.Location = new System.Drawing.Point(37, 368);
            this.lblMatricolaInserisciStudente.Name = "lblMatricolaInserisciStudente";
            this.lblMatricolaInserisciStudente.Size = new System.Drawing.Size(50, 13);
            this.lblMatricolaInserisciStudente.TabIndex = 30;
            this.lblMatricolaInserisciStudente.Text = "Matricola";
            // 
            // txtNomeInserisciStudente
            // 
            this.txtNomeInserisciStudente.Location = new System.Drawing.Point(68, 270);
            this.txtNomeInserisciStudente.Name = "txtNomeInserisciStudente";
            this.txtNomeInserisciStudente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeInserisciStudente.TabIndex = 32;
            // 
            // txtCognomeInserisciStudente
            // 
            this.txtCognomeInserisciStudente.Location = new System.Drawing.Point(86, 300);
            this.txtCognomeInserisciStudente.Name = "txtCognomeInserisciStudente";
            this.txtCognomeInserisciStudente.Size = new System.Drawing.Size(100, 20);
            this.txtCognomeInserisciStudente.TabIndex = 33;
            // 
            // cmbClasseInserisciStudente
            // 
            this.cmbClasseInserisciStudente.FormattingEnabled = true;
            this.cmbClasseInserisciStudente.Location = new System.Drawing.Point(76, 330);
            this.cmbClasseInserisciStudente.Name = "cmbClasseInserisciStudente";
            this.cmbClasseInserisciStudente.Size = new System.Drawing.Size(48, 21);
            this.cmbClasseInserisciStudente.TabIndex = 35;
            // 
            // txtMatricolaInserisciStudente
            // 
            this.txtMatricolaInserisciStudente.Location = new System.Drawing.Point(89, 365);
            this.txtMatricolaInserisciStudente.Name = "txtMatricolaInserisciStudente";
            this.txtMatricolaInserisciStudente.Size = new System.Drawing.Size(100, 20);
            this.txtMatricolaInserisciStudente.TabIndex = 36;
            // 
            // btnInserisciInserisciStudente
            // 
            this.btnInserisciInserisciStudente.Location = new System.Drawing.Point(72, 391);
            this.btnInserisciInserisciStudente.Name = "btnInserisciInserisciStudente";
            this.btnInserisciInserisciStudente.Size = new System.Drawing.Size(75, 23);
            this.btnInserisciInserisciStudente.TabIndex = 37;
            this.btnInserisciInserisciStudente.Text = "Inserisci";
            this.btnInserisciInserisciStudente.UseVisualStyleBackColor = true;
            this.btnInserisciInserisciStudente.Click += new System.EventHandler(this.btnInserisciStudente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 592);
            this.Controls.Add(this.btnInserisciInserisciStudente);
            this.Controls.Add(this.txtMatricolaInserisciStudente);
            this.Controls.Add(this.cmbClasseInserisciStudente);
            this.Controls.Add(this.txtCognomeInserisciStudente);
            this.Controls.Add(this.txtNomeInserisciStudente);
            this.Controls.Add(this.lblMatricolaInserisciStudente);
            this.Controls.Add(this.lblClasseInserisciStudente);
            this.Controls.Add(this.lblCognomeInserisciStudente);
            this.Controls.Add(this.lblNomeInserisciStudente);
            this.Controls.Add(this.lblInserisciStudente);
            this.Controls.Add(this.btnAggiungiAggiungiVoto);
            this.Controls.Add(this.lblVotoAggiungiVoto);
            this.Controls.Add(this.cmbVotoAggiungiVoto);
            this.Controls.Add(this.txtMatricolaAggiungiVoto);
            this.Controls.Add(this.lblMatricolaAggiungiVoto);
            this.Controls.Add(this.lblAggiungiVoto);
            this.Controls.Add(this.lblCercaStudente);
            this.Controls.Add(this.btnVisualizzaMaterie);
            this.Controls.Add(this.btnVisualizzaClassi);
            this.Controls.Add(this.lblMateriaAggiungiVoto);
            this.Controls.Add(this.cmbMateriaAggiungiVoto);
            this.Controls.Add(this.txtMatricolaCercaStudente);
            this.Controls.Add(this.txtCognomeCercaStudente);
            this.Controls.Add(this.txtNomeCercaStudente);
            this.Controls.Add(this.lblMatricolaCercaStudente);
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
        private System.Windows.Forms.Label lblMatricolaCercaStudente;
        private System.Windows.Forms.TextBox txtNomeCercaStudente;
        private System.Windows.Forms.TextBox txtCognomeCercaStudente;
        private System.Windows.Forms.TextBox txtMatricolaCercaStudente;
        private System.Windows.Forms.ComboBox cmbMateriaAggiungiVoto;
        private System.Windows.Forms.Label lblMateriaAggiungiVoto;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnVisualizzaClassi;
        private System.Windows.Forms.Button btnVisualizzaMaterie;
        private System.Windows.Forms.Label lblCercaStudente;
        private System.Windows.Forms.Label lblAggiungiVoto;
        private System.Windows.Forms.Label lblMatricolaAggiungiVoto;
        private System.Windows.Forms.TextBox txtMatricolaAggiungiVoto;
        private System.Windows.Forms.ComboBox cmbVotoAggiungiVoto;
        private System.Windows.Forms.Label lblVotoAggiungiVoto;
        private System.Windows.Forms.Button btnAggiungiAggiungiVoto;
        private System.Windows.Forms.Label lblInserisciStudente;
        private System.Windows.Forms.Label lblNomeInserisciStudente;
        private System.Windows.Forms.Label lblCognomeInserisciStudente;
        private System.Windows.Forms.Label lblClasseInserisciStudente;
        private System.Windows.Forms.Label lblMatricolaInserisciStudente;
        private System.Windows.Forms.TextBox txtNomeInserisciStudente;
        private System.Windows.Forms.TextBox txtCognomeInserisciStudente;
        private System.Windows.Forms.ComboBox cmbClasseInserisciStudente;
        private System.Windows.Forms.TextBox txtMatricolaInserisciStudente;
        private System.Windows.Forms.Button btnInserisciInserisciStudente;
    }
}

