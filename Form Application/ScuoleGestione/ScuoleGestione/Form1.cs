using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            DataSet ds = new DataSet();
            dtgrdvw.AutoGenerateColumns = true;
            dtgrdvw.DataSource = ds;
        }

        private void lblTestConnessioneDB_Click(object sender, EventArgs e)
        {
            var cs = "Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();

            lblTestConnessioneDB.Text = version;
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


            if (txtNome.Text != "")
            {
                sql += "AND nome LIKE '%" + txtNome.Text + "%'";
            }

            if (txtCognome.Text != "")
            {
                sql += "AND cognome LIKE '%" + txtCognome.Text + "%'";
            }

            if (txtMatricola.Text != "")
            {
                sql += "AND matricola = '" + txtMatricola.Text + "'";
            }

            if (cmbxMateria.SelectedIndex != -1)
            {
                sql += "AND materia = '" + cmbxMateria.Text + "'";
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

            var cs = "Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var anno = dtgrdvw.Rows[dtgrdvw.SelectedCells[0].RowIndex].Cells["anno"].Value;
            var sezione = dtgrdvw.Rows[dtgrdvw.SelectedCells[0].RowIndex].Cells["sezione"].Value;

            var sql = "DELETE FROM WHERE anno = " + anno + " AND sezione = '" + sezione + "'";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            cmd.ExecuteNonQuery();
        }
    }
}
