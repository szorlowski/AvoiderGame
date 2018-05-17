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
            UpdateList();
        }

        private void UpdateList()
        {
            SqlDataReader r = DBConnection.GetAllPlayers();
            AllPlayersList.Items.Clear();
            while (r.Read())
            {
                int vel = (int)r[1];
                int size = (int)r[2];
                string name = (string)r[0];
                int hp = (int)r[3];
                long score = (long)Convert.ToDouble(r[4]);
                AllPlayersList.Items.Add(new Player(vel, name, size, hp, score));
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Player player = (Player)AllPlayersList.SelectedItem;
            if (player != null)
            {
                player.ResetHP();
                GameForm game = new GameForm();
                game.StartGame(player);
            }
        }

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            Form form = new CreatePlayerForm();
            form.Show();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
            Player player = (Player)AllPlayersList.SelectedItem;
            DBConnection.DeletePlayerFromDB(player);
            UpdateList();
        }
    }
}
