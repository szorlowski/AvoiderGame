using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AvoiderGame
{
    public abstract class AbstractSquare
    {
        protected int vel;
        protected int size;
        protected Color color;
        public int power;

        public Color GetColor()
        {
            return color;
        }

        public int x { get; set; }
        public int y { get; set; }

        public AbstractSquare()
        {
            RandomizeLocation();
        }

        private void RandomizeLocation()
        {
            Random r = new Random();
            x = r.Next(1000 - size * 3);
            y = r.Next(800 - size * 3);
        }


        public int GetSize()
        {
            return size;
        }

        public int GetVel()
        {
            return vel;
        }

        public Boolean up = false;
        public Boolean down = false;
        public Boolean left = false;
        public Boolean right = false;

        public void SetUp()
        {
            up = true;
            down = false;
        }

        public void SetDown()
        {
            up = false;
            down = true;
        }

        public void SetLeft()
        {
            left = true;
            right = false;
        }

        public void SetRight()
        {
            left = false;
            right = true;
        }

        public virtual void MoveSquare(Player player)
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
