using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Game
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        List<Image> list = new List<Image>();
        int contador = 0;

        private void FormInicial_Load(object sender, EventArgs e)
        {
            list.Add(Properties.Resources.VirtualGuy);
            list.Add(Properties.Resources.PinkMan);
            list.Add(Properties.Resources.MaskDude);
            list.Add(Properties.Resources.Player);
        }

        private void pcBoxFormInicialNext_Click(object sender, EventArgs e)
        {
            if (contador == list.Count-1)
            {
                contador = 0;
            }
            else
            {
                pcBoxFormInicialPlayer.Image = list.ElementAt(contador++);
            }
        }

        private void pcBoxFormInicialPrevious_Click(object sender, EventArgs e)
        {
            if (contador != 0)
            {
                contador--;
            }
            pcBoxFormInicialPlayer.Image = list.ElementAt(contador);
        }

        private void bttnFormInicialConfirmar_Click(object sender, EventArgs e)
        {
            string path = @"C:\Jogo\teste\Player.png";
            pcBoxFormInicialPlayer.Image.Save(path);

            string connection = "server=localhost;port=3306;database=" +
        "joguinho;UID=root;password=''";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Player (url) VALUES (@url)";
            cmd.Parameters.AddWithValue("@url", path);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                
                FormJogo formJogo = new FormJogo();
                formJogo.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

