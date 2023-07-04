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
        public Form1()
        {
            InitializeComponent();
            dtgrdvw.AllowUserToAddRows = false;
            dtgrdvw.AllowUserToDeleteRows = false;
            /*
            DataSet ds = new DataSet();
            dtgrdvw.AutoGenerateColumns = true;
            dtgrdvw.DataSource = ds;

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
            HideElement();
        }

        private void HideElement()
        {
            lbl4.Visible = false;
            lbl5.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            btnCercaCercaStudente.Visible = false;
            lbl1.Visible = false;
            lbl3.Visible = false;
            lbl2.Visible = false;
            txt1.Visible = false;
            cmb2.Visible = false;
            cmb1.Visible = false;
        }

        private void lblTestConnessioneDB_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVisualizzaRegistro_Click(object sender, EventArgs e)
        {
            // visualizzazione del registro completo con un click
        }

        private void btnVisualizzaClassi_Click(object sender, EventArgs e)
        {
            // visualizza le classi presenti nella scuola
        }

        private void btnVisualizzaMaterie_Click(object sender, EventArgs e)
        {
            // visualizza le materie presenti nella scuola
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            // inserimento nuova riga nella tabella visualizzata
            // con dati studente (nome, cognome, matricola), classe (anno, sezione), voto (materia, voto);
            // trasformare le label con qualcosa di sensato in base a cosa bisogna inserire
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            // ricerca di elementi nella tabella visualizzata
            // trasformare le label con qualcosa di sensato in base a cosa si può cercare
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

    }
}
