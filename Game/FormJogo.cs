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
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }

        List<PictureBox> listaPb = new List<PictureBox>();
        int score = 0;

        private void formJogo_Load(object sender, EventArgs e)
        {
            // ABRIR CONEXAO COM O DB
            string connection = "server=localhost;port=3306;database=" +
            "joguinho;UID=root;password=''";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT url FROM Player " + "ORDER By IdPlayer desc limit 1";
                MySqlDataReader dr = cmd.ExecuteReader();
                string imagePath = "";
                if(dr.Read())
                {
                    imagePath = dr.GetValue(0).ToString();
                }
                ptBoxFJogoPlayer.ImageLocation = imagePath;
                conn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // RANDOMIZACAO E LOCALIZACAO DAS SERRAS
            Random rnd = new Random();
            int numeroRandomizado = rnd.Next(0, 238);

            PictureBox pb = new PictureBox();

            int x = pb.Location.X;
            int y = pb.Location.Y;

                // INSERCAO DE SERRAS EM LOCALIZACOES, Y, ALEATORIAS
                pb.Location = new Point(x: 541, y: numeroRandomizado);
                pb.Visible = true;
                pb.Height = 38;
                pb.Width = 38;
                pb.ImageLocation = @"C:\Jogo\Imagens\Off.png";
                this.Controls.Add(pb);

            listaPb.Add(pb);
            timer2.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // ACRESCIMO DE SCORE
            score++;
            lblScore.Text = "score: " + score.ToString();

            // DESLIZAMENTO DAS SERRAS
            PictureBox pbDeslizando = new PictureBox();
            pbDeslizando = listaPb.ElementAt(listaPb.Count - 1);
            pbDeslizando.Left -= 20;

            // COLISAO
            if (ptBoxFJogoPlayer.Bounds.IntersectsWith(pbDeslizando.Bounds)) {
               
                timer1.Enabled = false;
                timer2.Enabled = false;

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
                    if(dr.Read())
                    {
                        id = dr.GetValue(0).ToString();
                        conn.Close();
                    }

                    // UPDATE DE TABELA, ADICIONANDO SCORE AO URL
                    conn.Open();
                    cmd.CommandText = "UPDATE Player SET score=" + "@score where IdPlayer = @id;";
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("E-ew");

                    PlayerNome playernome = new PlayerNome();
                    playernome.ShowDialog();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormJogo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down) 
            {
                ptBoxFJogoPlayer.Location = new Point(ptBoxFJogoPlayer.Location.X, ptBoxFJogoPlayer.Location.Y + 15);
            }

            if (e.KeyCode == Keys.Up)
            {
                ptBoxFJogoPlayer.Location = new Point(ptBoxFJogoPlayer.Location.X, ptBoxFJogoPlayer.Location.Y - 15);
            }
        }
    }
}
