using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFMathSquare
{
    class Player
    {
        string axisName;
        int score;
        bool turn;        

        public Player (string name = "X", int score = 0, bool turn = false)
        {
            this.axisName = name;
            this.score = score;
            this.turn = turn;
        }

        public void changeScore (int delta)
        {
            score += delta;
        }

        public int getScore()
        {
            return score;
        }

        public bool isMyTurn()
        {
            return turn;
        }
        public void changeTurn()
        {
            turn = !turn;
        }
        public void setTurn(bool st)
        {
            turn = st;
        }

        public string getName()
        {
            return axisName;
        }
        public void setName(string n)
        {
            axisName = n;
        }
    }
}
