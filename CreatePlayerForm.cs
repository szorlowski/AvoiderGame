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
        private string PlayerName;
        private string Vel;
        private string Size;
        private string hp;
        List<string> errors;

        public CreatePlayerForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private bool IsMaxPlayers()
		{
			return DBConnection.NumOfPlayers() >= 20;
		}

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            errors = new List<string>();
            PlayerName = NewPlayerNameTextbox.Text;
            Vel = NewVelocityTextbox.Text;
            Size = NewSizeTextbox.Text;
            hp = NewHPTextBox.Text;
            if (IsValid())
            {
				if (!IsMaxPlayers())
				{
					Player NewPlayer = new Player(Int32.Parse(Vel), PlayerName, Int32.Parse(Size), Int32.Parse(hp), 0);
					DBConnection.AddPlayerToDB(NewPlayer);
					DBConnection.CloseConnection();
					this.Close();
				}
				else
				{
					MessageBox.Show("There is maximum players: 20");
				}

            }
            else
            {
                string msg = "";
                foreach (string s in errors)
                {
                    msg += s + "\n";
                }
                MessageBox.Show(msg);
            }

        }

        private bool CheckName()
        {
            return PlayerName.Length < 15 && PlayerName.Length > 0;
        }

        private bool CheckSize()
        {
            return int.TryParse(Size, out int n);
        }

        private bool CheckVel()
        {
            return int.TryParse(Vel, out int n);
        }

        private bool CheckHp()
        {
            return int.TryParse(hp, out int n);
        }

        private bool IsValid()
        {
            bool IsValid = true;
            if (!CheckName())
            {
                IsValid = false;
                errors.Add("Name cannot be blank or it is to long");
            }


            if (DBConnection.DoesNameExist(PlayerName)){
                IsValid = false;
                errors.Add("Name is already taken");
            }

            if (PlayerName.ToLower() == "dupa")
            {
                IsValid = false;
                errors.Add("This name is very sad :(");
            }

            if (!CheckSize())
            {
                IsValid = false;
                errors.Add("Size must be a integer");
            }
            else
            {
                int size = Int32.Parse(Size);
                if (size > 30 || size < 5)
                {
                    IsValid = false;
                    errors.Add("Size must be between 5-30");
                }
            }

            if (!CheckVel())
            {
                IsValid = false;
                errors.Add("Velocity must be a integer");
            }
            else
            {
                int vel = Int32.Parse(Vel);
                if (vel > 20 || vel < 5)
                {
                    IsValid = false;
                    errors.Add("Velocity must be between 5-20");
                }
            }

            if (!CheckHp())
            {
                IsValid = false;
                errors.Add("HP must be a integer");
            }
            else
            {
                int HP = Int32.Parse(hp);
                if (HP > 20 || HP < 5)
                {
                    IsValid = false;
                    errors.Add("HP must be between 5-20");
                }
            }

            return IsValid;
        }
	}
}
