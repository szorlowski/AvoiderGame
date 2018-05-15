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
            power = 1;
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
    }
}
