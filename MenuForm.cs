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

namespace AvoiderGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ToDo: get players from db
            AvoiderGameDataSet ds = new AvoiderGameDataSet();
            string connection = "Data Source =.\\SQLEXPRESS; Initial Catalog = AvoiderGame; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand sql = new SqlCommand("Select * from Players", conn);
            conn.Open();
            SqlDataReader r = sql.ExecuteReader();
            while (r.Read())
            {
                int vel = (int)r[1];
                int size = (int) r[2];
                string name = (string) r[0];
                int hp = (int) r[3];
                AllPlayersList.Items.Add(new Player(vel, name, size, hp));
            }
            conn.Close();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Player player = (Player)AllPlayersList.SelectedItem;
            player.ResetHP();
            GameForm game = new GameForm();
            //ToDo: Protect from null
            game.StartGame(player);
        }

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            Form form = new CreatePlayerForm();
            form.Show();

        }
    }
}
