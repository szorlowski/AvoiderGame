using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AvoiderGame
{
    class SmartEnemy : BaseEnemy
    {

        public SmartEnemy()
        {
            vel = 1;
            size = 12;
            color = Color.Black;
        }

    // ToDo: find better way to move smart enemy
    override
    public void MoveEnemy(Player player)
        {
            if (player.y < y) SetUp();
            if (player.y > y) SetDown();
            if (player.x < x) SetLeft();
            if (player.x > x) SetRight();

            if (up) y -= vel;
            if (down) y += vel;
            if (right) x += vel;
            if (left) x -= vel;
        }
    }
}
