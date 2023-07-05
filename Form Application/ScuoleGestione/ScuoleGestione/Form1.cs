using Npgsql;
using System;
using System.Collections;
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
        private string action = "";

        public Form1()
        {
            InitializeComponent();
            dtgrdvw.AllowUserToAddRows = false;
            dtgrdvw.AllowUserToDeleteRows = false;
            
            DataSet ds = new DataSet();
            dtgrdvw.AutoGenerateColumns = true;
            dtgrdvw.DataSource = ds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideForm();
        }

        private void btnVisualizzaStudenti_Click(object sender, EventArgs e)
        {
            HideForm();
            ClearFieldValue();
            Enable("Studente");

            
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM studenti";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            
        }

        private void btnVisualizzaClassi_Click(object sender, EventArgs e)
        {
            HideForm();
            ClearFieldValue();
            Enable("Classe");

            
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM classi";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            
        }

        private void btnVisualizzaRegistro_Click(object sender, EventArgs e)
        {
            HideForm();
            ClearFieldValue();
            Enable("Voto");

            
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM voti";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            
        }

        private void btnVisualizzaMaterie_Click(object sender, EventArgs e)
        {
            HideForm();
            ClearFieldValue();
            Enable("Materia");

            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            var sql = "SELECT * FROM materie";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
            
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowForm("Inserisci-" + table);
            action = "Inserisci";
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowForm("Ricerca-" + table);
            action = "Ricerca";
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowForm("Modifica-" + table);
            action = "Modifica";
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowForm("Elimina-" + table);
            action = "Elimina";
        }

        private void dtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (table)
            {
                case "Studente":
                    btnModifica.Enabled = true;
                    btnElimina.Enabled = true;
                    break;
                case "Voto":
                    btnModifica.Enabled = true;
                    btnElimina.Enabled = true;
                    break;
                case "Materia":
                    btnModifica.Enabled = true;
                    btnElimina.Enabled = true;
                    break;
                case "Classe":
                    btnElimina.Enabled = true;
                    break;
            }
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
                    PopulateCombo(1, "Classe");
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
                    PopulateCombo(1, "Voto");
                    cmb2.Visible = true;
                    PopulateCombo(2, "Materia");
                    btn1.Visible = true;
                    btn1.Text = "Inserisci";
                    break;

                case "Inserisci-Classe":
                    lbl0.Visible = true;
                    lbl0.Text = "Inserisci Classe";
                    lbl1.Visible = true;
                    lbl1.Text = "Classe";
                    txt1.Visible = true;
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
                    PopulateCombo(1, "Classe");
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
                    btn1.Text = "Ricerca";
                    break;

                case "Modifica-Studente":
                    lbl0.Visible = true;
                    lbl0.Text = "Modifica Studente";
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
                    PopulateCombo(1, "Classe");
                    btn1.Visible = true;
                    btn1.Text = "Modifica";

                    txt1.Text = dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["matricola"].Value.ToString();
                    txt2.Text = dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["nome"].Value.ToString();
                    txt3.Text = dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["cognome"].Value.ToString();
                    cmb1.Text = dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["anno_classe"].Value.ToString() + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["sezione_classe"].Value.ToString();

                    break;

                case "Modifica-Voto":
                    lbl0.Visible = true;
                    lbl0.Text = "Modifica Voto";
                    lbl1.Visible = true;
                    lbl1.Text = "Matricola";
                    lbl2.Visible = true;
                    lbl2.Text = "Voto";
                    lbl3.Visible = true;
                    lbl3.Text = "Materia";
                    txt1.Visible = true;
                    cmb1.Visible = true;
                    PopulateCombo(1, "Voto");
                    cmb2.Visible = true;
                    PopulateCombo(2, "Materia");
                    btn1.Visible = true;
                    btn1.Text = "Modifica";

                    txt1.Text = dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["matricola"].Value.ToString();
                    cmb1.Text = dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["voto"].Value.ToString();
                    cmb2.Text = dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["materia"].Value.ToString();


                    break;

                case "Modifica-Materia":
                    lbl0.Visible = true;
                    lbl0.Text = "Modifica Materia";
                    lbl1.Visible = true;
                    lbl1.Text = "Materia";
                    txt1.Visible = true;
                    btn1.Visible = true;
                    btn1.Text = "Modifica";
                    break;

                case "Elimina-Studente":
                    btn1.Visible = true;
                    btn1.Text = "Elimina";
                    break;

                case "Elimina-Voto":
                    btn1.Visible = true;
                    btn1.Text = "Elimina";
                    break;

                case "Elimina-Classe":
                    btn1.Visible = true;
                    btn1.Text = "Elimina";
                    break;

                case "Elimina-Materia":
                    btn1.Visible = true;
                    btn1.Text = "Elimina";
                    break;
            }
        }

        private void ExecuteSelect(string query)
        {
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtgrdvw.DataSource = table;

            con.Close();
        }

        private void ExecuteOther(string query)
        {
            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Errore nell'operazione " + action);
            }

            con.Close();
        }

        private void PopulateCombo(int cmbNumber, string table)
        {
            string query = "";

            var con = new NpgsqlConnection("Host=192.168.11.17; Username=postgres; Password=1234abcd; Database=gabba_DB");
            con.Open();

            NpgsqlCommand cmd;
            NpgsqlDataReader drd;

            switch (table)
            {
                case "Voto":
                    switch (cmbNumber)
                    {
                        case 1:
                            cmb1.Items.Clear();

                            cmb1.Items.Add("10");

                            cmb1.Items.Add("9.75");
                            cmb1.Items.Add("9.5");
                            cmb1.Items.Add("9.25");
                            cmb1.Items.Add("9");

                            cmb1.Items.Add("8.75");
                            cmb1.Items.Add("8.5");
                            cmb1.Items.Add("8.25");
                            cmb1.Items.Add("8");

                            cmb1.Items.Add("7.75");
                            cmb1.Items.Add("7.5");
                            cmb1.Items.Add("7.25");
                            cmb1.Items.Add("7");

                            cmb1.Items.Add("6.75");
                            cmb1.Items.Add("6.5");
                            cmb1.Items.Add("6.25");
                            cmb1.Items.Add("6");

                            cmb1.Items.Add("5.75");
                            cmb1.Items.Add("5.5");
                            cmb1.Items.Add("5.25");
                            cmb1.Items.Add("5");

                            cmb1.Items.Add("4.75");
                            cmb1.Items.Add("4.5");
                            cmb1.Items.Add("4.25");
                            cmb1.Items.Add("4");

                            cmb1.Items.Add("3.75");
                            cmb1.Items.Add("3.5");
                            cmb1.Items.Add("3.25");
                            cmb1.Items.Add("3");

                            cmb1.Items.Add("2.75");
                            cmb1.Items.Add("2.5");
                            cmb1.Items.Add("2.25");
                            cmb1.Items.Add("2");

                            cmb1.Items.Add("1.75");
                            cmb1.Items.Add("1.5");
                            cmb1.Items.Add("1.25");
                            cmb1.Items.Add("1");

                            break;

                        case 2:
                            cmb2.Items.Clear();

                            cmb2.Items.Add("10");

                            cmb2.Items.Add("9.75");
                            cmb2.Items.Add("9.5");
                            cmb2.Items.Add("9.25");
                            cmb2.Items.Add("9");

                            cmb2.Items.Add("8.75");
                            cmb2.Items.Add("8.5");
                            cmb2.Items.Add("8.25");
                            cmb2.Items.Add("8");

                            cmb2.Items.Add("7.75");
                            cmb2.Items.Add("7.5");
                            cmb2.Items.Add("7.25");
                            cmb2.Items.Add("7");

                            cmb2.Items.Add("6.75");
                            cmb2.Items.Add("6.5");
                            cmb2.Items.Add("6.25");
                            cmb2.Items.Add("6");

                            cmb2.Items.Add("5.75");
                            cmb2.Items.Add("5.5");
                            cmb2.Items.Add("5.25");
                            cmb2.Items.Add("5");

                            cmb2.Items.Add("4.75");
                            cmb2.Items.Add("4.5");
                            cmb2.Items.Add("4.25");
                            cmb2.Items.Add("4");

                            cmb2.Items.Add("3.75");
                            cmb2.Items.Add("3.5");
                            cmb2.Items.Add("3.25");
                            cmb2.Items.Add("3");

                            cmb2.Items.Add("2.75");
                            cmb2.Items.Add("2.5");
                            cmb2.Items.Add("2.25");
                            cmb2.Items.Add("2");

                            cmb2.Items.Add("1.75");
                            cmb2.Items.Add("1.5");
                            cmb2.Items.Add("1.25");
                            cmb2.Items.Add("1");

                            break;
                    }
                    break;

                case "Materia":
                    query = "SELECT * FROM materie";
                    cmd = new NpgsqlCommand(query, con);

                    drd = cmd.ExecuteReader();

                    switch (cmbNumber)
                    {
                        case 1:
                            cmb1.Items.Clear();
                            while (drd.Read())
                            {
                                cmb1.Items.Add(drd["materia"].ToString());
                            }
                            break;

                        case 2:
                            cmb2.Items.Clear();
                            while (drd.Read())
                            {
                                cmb2.Items.Add(drd["materia"].ToString());
                            }
                            break;
                    }
                    break;

                case "Classe":
                    query = "SELECT DISTINCT anno || sezione AS classe FROM classi ORDER BY classe";
                    cmd = new NpgsqlCommand(query, con);

                    drd = cmd.ExecuteReader();

                    switch (cmbNumber)
                    {
                        case 1:
                            cmb1.Items.Clear();
                            while (drd.Read())
                            {
                                cmb1.Items.Add(drd["classe"].ToString());
                            }
                            break;

                        case 2:
                            cmb2.Items.Clear();
                            while (drd.Read())
                            {
                                cmb2.Items.Add(drd["classe"].ToString());
                            }
                            break;
                    }
                    break;
            }

            con.Close();
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

        public void ClearFieldValue()
        {
            cmb1.Text = "";
            cmb2.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (action)
            {
                case "Inserisci":
                    query = "INSERT INTO ";
                    switch (table)
                    {
                        case "Studente":
                            query += "studenti(matricola, nome, cognome, anno_classe, sezione_classe) VALUES ('" + txt1.Text + "', '" + txt2.Text + "', '" + txt3.Text + "', " + cmb1.Text.ToCharArray()[0] + ", '" + cmb1.Text.ToCharArray()[1] + "')";
                            break;

                        case "Voto":
                            query += "voti(matricola, materia, voto) VALUES ('" + txt1.Text + "', '" + cmb2.Text + "', '" + cmb1.Text + "')";
                            break;

                        case "Materia":
                            query += "materie(materia) VALUES ('" + txt1.Text + "')";
                            break;

                        case "Classe":
                            query += "classi(anno, sezione) VALUES (" + txt1.Text.ToCharArray()[0] + ", '" + txt1.Text.ToCharArray()[1] + "')";
                            break;
                    }

                    ExecuteOther(query);

                    break;

                case "Ricerca":
                    query = "SELECT * FROM ";
                    switch (table)
                    {
                        case "Studente":
                            query += "studenti WHERE matricola LIKE '%" + txt1.Text + "%' AND nome LIKE '%" + txt2.Text + "%' AND cognome LIKE '%" + txt3.Text + "%'";
                            if (cmb1.SelectedIndex != -1)
                            {
                                query += " AND anno_classe = " + cmb1.Text.ToCharArray()[0] + " AND sezione_classe LIKE '%" + cmb1.Text.ToCharArray()[1] + "%'";
                            }
                            break;

                        case "Voto":
                            query += "voti WHERE matricola LIKE '%" + txt1.Text + "%'";
                            break;
                    }

                    ExecuteSelect(query);

                    break;

                case "Modifica":
                    query = "UPDATE ";
                    switch (table)
                    {
                        case "Studente":
                            query += "studenti SET matricola = '" + txt1.Text + "', nome = '" + txt2.Text + "', cognome = '" + txt3.Text + "', anno_classe = " + cmb1.Text.ToCharArray()[0] + ", sezione_classe = '" + cmb1.Text.ToCharArray()[1] + "' WHERE matricola = '" + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["matricola"].Value.ToString() + "'";
                            break;

                        case "Voto":
                            query += "voti SET matricola = '" + txt1.Text + "', voto = '" + cmb1.Text + "', materia = '" + cmb2.Text + "' WHERE idvoto = '" + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["idvoto"].Value.ToString() + "'";
                            break;

                        case "Materia":
                            query += "materie SET materia = '" + txt1.Text + "' WHERE materia = '" + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["materia"].Value.ToString() + "'";
                            break;
                    }

                    ExecuteOther(query);

                    break;

                case "Elimina":
                    query = "DELETE FROM ";
                    switch (table)
                    {
                        case "Studente":
                            query += "studenti WHERE matricola = '" + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["matricola"].Value.ToString() + "'";
                            break;

                        case "Voto":
                            query += "voti WHERE idvoto = '" + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["idvoto"].Value.ToString() + "'";
                            break;

                        case "Materia":
                            query += "materie WHERE materia = '" + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["materia"].Value.ToString() + "'";
                            break;

                        case "Classe":
                            query += "classi WHERE anno = " + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["anno"].Value.ToString() + " AND sezione = '" + dtgrdvw.Rows[dtgrdvw.CurrentCell.RowIndex].Cells["sezione"].Value.ToString() + "'";
                            break;
                    }

                    ExecuteOther(query);

                    break;
            }
        }

    }
}
