using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            AllPlayersList.Items.Add(new Player(5, "Test User", 20, 20));
            AllPlayersList.Items.Add(new Player(10, "Test User", 10, 5));
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
