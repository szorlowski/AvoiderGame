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
    public partial class CreatePlayerForm : Form
    {
        public CreatePlayerForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            string PlayerName = NewPlayerNameTextbox.Text;
            string Vel = NewVelocityTextbox.Text;
            string Size = NewSizeTextbox.Text;
            string hp = NewHPTextBox.Text;
            Player NewPlayer = new Player(Int32.Parse(Vel), PlayerName, Int32.Parse(Size), Int32.Parse(hp), 0);
            DBConnection.AddPlayerToDB(NewPlayer);
            DBConnection.CloseConnection();
            this.Close();
        }


    }
}
