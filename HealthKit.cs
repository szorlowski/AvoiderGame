using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AvoiderGame
{
    class HealthKit : AbstractSquare
    {
        public HealthKit()
        {
            vel = 0;
            color = Color.Pink;
            power = -5;
            size = 10;
        }
    }
}
