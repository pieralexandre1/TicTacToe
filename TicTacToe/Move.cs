using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Move
    {

        private int score;
        private int index;

        public Move()
        {

        }

        public int getScore()
        {
            return score;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public int getIndex()
        {
            return index;
        }

        public void setIndex(int index)
        {
            this.index = index;
        }
    }
}
