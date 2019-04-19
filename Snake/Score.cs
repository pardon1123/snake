using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Score
    {
        int score = 0;

        public void Plus()
        {
            score++;
        }

        public int Show()
        {
            return score;
        }
    }
}
