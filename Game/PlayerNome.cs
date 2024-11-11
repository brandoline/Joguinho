using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class PlayerNome : Form
    {
        public PlayerNome()
        {
            InitializeComponent();
        }

        private void bttnNnConfirmar_Click(object sender, EventArgs e)
        {
            // ADICAO DE NICKNAME AO PLAYER
            string connection = "server=localhost;port=3306;database=" +
            "joguinho;UID=root;password=''";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                // CONFERENCIA DE ID
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT IdPlayer FROM Player order by IdPlayer desc limit 1;";
                MySqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                if (dr.Read())
                {
                    id = dr.GetValue(0).ToString();
                    conn.Close();
                }

                // UPDATE DE TABELA, ADICIONANDO NICK AO ID
                conn.Open();
                cmd.CommandText = "UPDATE Player SET nome=" + "@nome where IdPlayer = @id;";
                cmd.Parameters.AddWithValue("@nome", txtBoxNnNome.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salvo!");

                HistoricoPartidas hp = new HistoricoPartidas();
                hp.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
