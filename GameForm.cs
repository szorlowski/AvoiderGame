﻿using System;
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
    public partial class GameForm : Form
    {
        private long currentScore = 0;
        Player player;
        ICollection<BaseEnemy> enemies = new List<BaseEnemy>();

        public GameForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        public void StartGame(Player player)
        {
            this.player = player;
            this.Show();
        }

        private void CountScore()
        {
            ScoreTextBox.Text = currentScore.ToString();
            currentScore += 1;
        }

        private void Score_Tick_1(object sender, EventArgs e)
        {
            CountScore();
            HPTextBox.Text = player.GetCurrentHp().ToString();
            MovePlayer(player);
            if (currentScore % 100 == 0)
                CreateBaseEnemy();
            if (currentScore % 300 == 0)
                CreateFastEnemy();
            if (currentScore % 500 == 0)
                CreateSmartEnemy();

            foreach (BaseEnemy be in enemies.Reverse<BaseEnemy>())
            {
                if (player.CheckCollission(be))
                {
                    player.SetCurrentHp(player.GetCurrentHp() - 1);
                    enemies.Remove(be);                    
                    if(player.GetCurrentHp() == 0)
                    {
                        this.Close();
                        //ToDo: save score to DB
                    }
                }
                else
                {
                    be.MoveEnemy(player);
                }
            }
            Invalidate();
        }

        private void CreateBaseEnemy()
        {
            enemies.Add(new BaseEnemy());
        }

        private void CreateFastEnemy()
        {
            enemies.Add(new FastEnemy());
        }

        private void CreateSmartEnemy()
        {
            enemies.Add(new SmartEnemy());
        }

        private void MovePlayer(Player player)
        {
            int dis = player.GetVel();
            if (player.up)
            {
                if (player.y > 0)
                    player.y -= dis;
            }
            if (player.down)
            {
                // ToDo: handle this error on bottom edge
                if (player.y + 2 * player.GetSize() < this.Height)
                    player.y += dis;
            }
            if (player.left)
            {
                if (player.x > 0)
                    player.x -= dis;
            }
            if (player.right)
            {
                if (player.x + 2 * player.GetSize() < this.Width)
                    player.x += dis;
            }
        }
        

        private void RenderSquare(AbstractSquare square, PaintEventArgs e)
        {
            Brush myBrush = new SolidBrush(square.GetColor());
            int size = square.GetSize();
            e.Graphics.FillRectangle(myBrush, new Rectangle(square.x, square.y, size, size));
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            RenderSquare(player, e);
            foreach (BaseEnemy be in enemies)
            {
                RenderSquare(be, e);
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) player.SetLeft();
            if (e.KeyCode == Keys.Right) player.SetRight();
            if (e.KeyCode == Keys.Up) player.SetUp();
            if (e.KeyCode == Keys.Down) player.SetDown();
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) player.left = false;
            if (e.KeyCode == Keys.Right) player.right = false;
            if (e.KeyCode == Keys.Up) player.up = false;
            if (e.KeyCode == Keys.Down) player.down = false;
        }
    }
}