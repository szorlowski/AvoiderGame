using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AvoiderGame
{
    public delegate void Alarm(string message);
    public class Player : AbstractSquare
    {
        public event Alarm LowHealth;
        int maxHp;
        int currentHp;
        protected string name;
        private long maxScore;
        public Player(int vel, string name, int size, int hp, long maxScore)
        {

            this.vel = vel;
            this.name = name;
            this.size = size;
            color = Color.Green;
            maxHp = hp;
            currentHp = hp;
            this.maxScore = maxScore;

        }
        public int getMaxHp()
        {
            return maxHp;
        }

        public int GetCurrentHp()
        {
            if (LowHealth != null && currentHp < 5)
            {
                LowHealth("Needs health");
            }
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
            return name + ", vel:  " + vel + ", size: " + size + ", health: " + maxHp + ", max score: " + maxScore;
        }

        public bool CheckCollission(AbstractSquare be)
        {
            Rectangle r1 = new Rectangle(x, y, size, size);
            Rectangle r2 = new Rectangle(be.x, be.y, be.GetSize(), be.GetSize());
            return r1.IntersectsWith(r2);
        }

        public string GetName()
        {
            return name;
        }

        public long GetMaxScore()
        {
            return maxScore;
        }
    }
}
