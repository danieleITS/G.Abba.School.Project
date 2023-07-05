using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScuoleGestione
{
    public partial class Form1 : Form
    {
        private string table = "";

        public Form1()
        {
            InitializeComponent();
            dtgrdvw.AllowUserToAddRows = false;
            dtgrdvw.AllowUserToDeleteRows = false;
            
            DataSet ds = new DataSet();
            dtgrdvw.AutoGenerateColumns = true;
            dtgrdvw.DataSource = ds;
            /*
            var cs = "Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM materie";

            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                cmbMateriaAggiungiVoto.Items.Add(drd["materia"].ToString());
            }

            con.Close();

            con.Open();

            sql = "SELECT DISTINCT anno || sezione AS classe FROM classi ORDER BY classe";

            cmd = new NpgsqlCommand(sql, con);

            drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                cmbClasseInserisciStudente.Items.Add(drd["classe"].ToString());
            }
            */
        }

        private void lblTestConnessioneDB_Click(object sender, EventArgs e)
        {
            
        }

        

        

        

        

        

        private void btnCerca_Click(object sender, EventArgs e)
        {
            // bottone per la conferma della ricerca

            var cs = "Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM studenti WHERE true ";


            if (txt2.Text != "")
            {
                sql += "AND nome LIKE '%" + txt2.Text + "%'";
            }

            if (txt3.Text != "")
            {
                sql += "AND cognome LIKE '%" + txt3.Text + "%'";
            }

            if (txt1.Text != "")
            {
                sql += "AND matricola = '" + txt1.Text + "'";
            }

            if (cmb1.SelectedIndex != -1)
            {
                sql += "AND materia = '" + cmb1.Text + "'";
            }

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            dtgrdvw.DataSource = table;
            lblTestConnessioneDB.Text = table.TableName;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            // modifica della riga selezionata nella tabella visualizzata
            // trasformare le label con qualcosa di sensato in base a cosa si può modificare
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            // eliminazzione della riga selezionata nella tabella visualizzata
            // stampare un messaggio di conferma tramite message box
            

        }

        private void btnAggiungiVoto_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && cmb2.SelectedIndex != -1 && cmb1.SelectedIndex != -1)
            {
                //scrivere la query di insert qui uwu
                NpgsqlConnection con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");

                con.Open();

                var query = "INSERT INTO public.voti(matricola, materia, voto) VALUES ('" + txt1.Text + "', '" + cmb1.SelectedItem + "', '" + cmb2.SelectedItem + "');";
                Console.WriteLine(query);

                NpgsqlCommand command = new NpgsqlCommand(query, con);

                command.ExecuteNonQuery();

                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideForm();
        }

        private void btnInserisciStudente_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "" && txt3.Text != "" && txt1.Text != "" && cmb2.SelectedIndex != -1)
            {
                //scrivere la query di insert qui uwu
                NpgsqlConnection con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");

                con.Open();

                var query = "INSERT INTO public.studenti(matricola, nome, cognome, anno_classe, sezione_classe) VALUES ('" + txt1.Text + "', '" + txt2.Text + "', '" + txt3.Text + "', " + cmb1.SelectedItem.ToString().ToCharArray()[0] + ", '" + cmb1.SelectedItem.ToString().ToCharArray()[1] + "')";
                Console.WriteLine(query);

                NpgsqlCommand command = new NpgsqlCommand(query, con);

                command.ExecuteNonQuery();

                con.Close();
            }
        }



























        private void btnVisualizzaStudenti_Click(object sender, EventArgs e)
        {
            HideForm();
            Enable("Studente");

            /*
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM studenti";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            */
        }

        private void btnVisualizzaClassi_Click(object sender, EventArgs e)
        {
            HideForm();
            Enable("Classe");

            /*
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM classi";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            */
        }

        private void btnVisualizzaRegistro_Click(object sender, EventArgs e)
        {
            HideForm();
            Enable("Voto");

            /*
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM voti";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            */
        }

        private void btnVisualizzaMaterie_Click(object sender, EventArgs e)
        {
            HideForm();
            Enable("Materia");

            /*
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM materie";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            */
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowForm("Inserisci-" + table);
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowForm("Ricerca-" + table);
        }

        private void dtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void HideForm()
        {
            btnInserisci.Enabled = false;
            btnRicerca.Enabled = false;
            btnModifica.Enabled = false;
            btnElimina.Enabled = false;
            lbl0.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            cmb1.Visible = false;
            cmb2.Visible = false;
            btn1.Visible = false;
        }

        private void ShowForm(string usage)
        {
            switch (usage)
            {
                case "Inserisci-Studente":
                    lbl0.Visible = true;
                    lbl0.Text = "Inserisci Studente";
                    lbl1.Visible = true;
                    lbl1.Text = "Matricola";
                    lbl2.Visible = true;
                    lbl2.Text = "Classe";
                    lbl4.Visible = true;
                    lbl4.Text = "Nome";
                    lbl5.Visible = true;
                    lbl5.Text = "Cognome";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    cmb1.Visible = true;
                    btn1.Visible = true;
                    btn1.Text = "Inserisci";
                    break;

                case "Inserisci-Voto":
                    lbl0.Visible = true;
                    lbl0.Text = "Inserisci Voto";
                    lbl1.Visible = true;
                    lbl1.Text = "Matricola";
                    lbl2.Visible = true;
                    lbl2.Text = "Voto";
                    lbl3.Visible = true;
                    lbl3.Text = "Materia";
                    txt1.Visible = true;
                    cmb1.Visible = true;
                    cmb2.Visible = true;
                    btn1.Visible = true;
                    btn1.Text = "Inserisci";
                    break;

                case "Inserisci-Classe":
                    lbl0.Visible = true;
                    lbl0.Text = "Inserisci Classe";
                    lbl2.Visible = true;
                    lbl2.Text = "Anno";
                    lbl3.Visible = true;
                    lbl3.Text = "Sezione";
                    cmb1.Visible = true;
                    cmb2.Visible = true;
                    btn1.Visible = true;
                    btn1.Text = "Inserisci";
                    break;

                case "Inserisci-Materia":
                    lbl0.Visible = true;
                    lbl0.Text = "Inserisci Materia";
                    lbl1.Visible = true;
                    lbl1.Text = "Materia";
                    txt1.Visible = true;
                    btn1.Visible = true;
                    btn1.Text = "Inserisci";
                    break;

                case "Ricerca-Studente":
                    lbl0.Visible = true;
                    lbl0.Text = "Ricerca Studente";
                    lbl1.Visible = true;
                    lbl1.Text = "Matricola";
                    lbl2.Visible = true;
                    lbl2.Text = "Classe";
                    lbl4.Visible = true;
                    lbl4.Text = "Nome";
                    lbl5.Visible = true;
                    lbl5.Text = "Cognome";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    cmb1.Visible = true;
                    btn1.Visible = true;
                    btn1.Text = "Ricerca";
                    break;

                case "Ricerca-Voto":
                    lbl0.Visible = true;
                    lbl0.Text = "Ricerca Voto";
                    lbl1.Visible = true;
                    lbl1.Text = "Matricola";
                    txt1.Visible = true;
                    btn1.Visible = true;
                    break;

                case "Modifica-Studente":
                    break;

                case "Modifica-Voto":
                    break;

                case "Modifica-Materia":
                    break;

                case "Elimina-Studente":
                    break;

                case "Elimina-Voto":
                    break;

                case "Elimina-Classe":
                    break;

                case "Elimina-Materia":
                    break;
            }
        }

        private void Enable(string button)
        {
            switch (button)
            {
                case "Studente":
                    btnInserisci.Enabled = true;
                    btnRicerca.Enabled = true;
                    table = "Studente";
                    break;
                case "Classe":
                    btnInserisci.Enabled = true;
                    table = "Classe";
                    break;
                case "Voto":
                    btnInserisci.Enabled = true;
                    btnRicerca.Enabled = true;
                    table = "Voto";
                    break;
                case "Materia":
                    btnInserisci.Enabled = true;
                    table = "Materia";
                    break;
            }
        }
    }
}
