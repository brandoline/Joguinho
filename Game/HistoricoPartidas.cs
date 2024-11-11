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
    public partial class HistoricoPartidas : Form
    {
        public HistoricoPartidas()
        {
            InitializeComponent();
        }

        private void HistoricoPartidas_Load(object sender, EventArgs e)
        {
            // ABRIR CONEXAO COM O DB
            string connection = "server=localhost;port=3306;database=" +
            "joguinho;UID=root;password=''";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT nome, score FROM Player ORDER BY SCORE DESC;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
