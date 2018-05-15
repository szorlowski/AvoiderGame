using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AvoiderGame
{
    class FastEnemy : BaseEnemy
    {
        public FastEnemy()
        {
            color = Color.Blue;
            vel = 10;
            size = 8;
        }
    }
}
