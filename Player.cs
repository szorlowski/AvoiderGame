﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AvoiderGame
{
    public class Player : AbstractSquare
    {
        int maxHp;
        int currentHp;
        protected string name;
        public Player(int vel, string name, int size, int hp)
        {
            
            this.vel = vel;
            this.name = name;
            this.size = size;
            color = Color.Green;
            maxHp = hp;
            currentHp = hp;

        }

        public int getMaxHp()
        {
            return maxHp;
        }

        public int GetCurrentHp()
        {
            return currentHp;
        }

        public void SetCurrentHp(int hp)
        {
            currentHp = hp;
        }

        public void ResetHP()
        {
            currentHp = maxHp;
        }

        public override string ToString()
        {
            return name + ", vel:  " + vel + ", size: " + size;
        }

        public Boolean CheckCollission(BaseEnemy be)
        {
            Rectangle r1 = new Rectangle(x, y, size, size);
            Rectangle r2 = new Rectangle(be.x, be.y, be.GetSize(), be.GetSize());
            return r1.IntersectsWith(r2);


        }
    }
}
