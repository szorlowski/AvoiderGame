using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AvoiderGame
{
    public class BaseEnemy : AbstractSquare
    {
        public BaseEnemy()
        {
            vel = 5;
            size = 10;
            color = Color.Red;
            Random r = new Random();
            for (int i = 0; i < 2; i++)
            {
                switch (r.Next(0, 4))
                {
                    case 0:
                        SetUp();
                        break;
                    case 1:
                        SetDown();
                        break;
                    case 2:
                        SetRight();
                        break;
                    case 3:
                        SetLeft();
                        break;
                }
            }
        }

        public virtual void MoveEnemy(Player player)
        {
            int dis = GetVel();
            if (up)
            {
                if (y > 0)
                {
                    y -= dis;
                }
                else
                {
                    SetDown();
                }
            }
            else
            {
                if (down)
                {
                    // ToDo: handle this error on bottom edge
                    if (y + 2 * GetSize() < 800)
                    {
                        y += dis;
                    }
                    else
                    {
                        SetUp();
                    }
                }
            }

            if (left)
            {
                if (x > 0)
                {
                    x -= dis;
                }
                else
                {
                    SetRight();
                }
            }
            else
            {
                if (right)
                {
                    if (x + 2 * GetSize() < 1000)
                    {
                        x += dis;
                    }
                    else
                    {
                        SetLeft();
                    }
                }
            }

        }

    }
}
