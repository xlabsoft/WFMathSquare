using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMathSquare
{
    public partial class MainForm : Form
    {
        Player leftPlayer = new Player();
        Player rightPlayer = new Player();
        Player currentPlayer;
        ColorSet colorSet;
        public MainForm()
        {
            InitializeComponent();
            SelectFirstTurn();
            SelectAxis();
            colorSet = new ColorSet(2);//new ColorSet(RandomBool() == true ? 1 : 2);
            StartGame();
        }

        private void StartGame()
        {
            currentPlayer = leftPlayer.isMyTurn() ? leftPlayer : rightPlayer;
            UpdateInfo();

            if (currentPlayer.Equals(leftPlayer))
            {
                panelPlayerRight.Enabled = false;
                panelPlayerLeft.Enabled = true;
            }
            else
            {
                panelPlayerLeft.Enabled = false;
                panelPlayerRight.Enabled = true;
            }

        }

        private void UpdateInfo()
        {
            lblNameL.Text = leftPlayer.getName();
            lblScoreL.Text = leftPlayer.getScore().ToString();
            if (leftPlayer.getName() == "X")
            {
                lbldirL.Text = "⇄";
            }
            else
            {
                lbldirL.Text = "⇅";
            }

            lblNameR.Text = rightPlayer.getName();
            lblScoreR.Text = rightPlayer.getScore().ToString();
            if (rightPlayer.getName() == "X")
            {
                lbldirR.Text = "⇄";
            }
            else
            {
                lbldirR.Text = "⇅";
            }
        }

        private void SelectAxis()
        {
            if (RandomBool())
            {
                leftPlayer.setName("X");
                rightPlayer.setName("Y");
            }
            else
            {
                leftPlayer.setName("Y");
                rightPlayer.setName("X");
            }
        }

        private void SelectFirstTurn()
        {
            bool turn = RandomBool();
            leftPlayer.setTurn(turn);
            rightPlayer.setTurn(!turn);
        }

        int size = 7;
        Button[,] buttons = new Button[7, 7];
        int top = 10;
        int left = 10;
        int buttonSize = 60;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button btn = new Button();
                    float new_size = 14.0f;
                    btn.Font = new Font(btn.Font.FontFamily, new_size, btn.Font.Style);

                    int value = GenerateRandomDigit(rnd);
                    btn.Text = value.ToString();
                    btn.Tag = "btn" + i.ToString() + j.ToString();
                    btn.Location = new Point(top, left);
                    btn.Top = top;
                    btn.Left = left;
                    btn.Width = buttonSize;
                    btn.Height = buttonSize;
                    btn.BackColor = value < 0 ? Color.Coral : Color.Aqua;
                    buttons[i, j] = btn;
                    buttons[i, j].Click += btns_Click;
                    panelMain.Controls.Add(buttons[i, j]);
                    top += btn.Height + 2;
                    if (j == size - 1)
                    {
                        left += buttonSize;
                        top = 10;
                    }
                }
            }

            hideButtons("btn33");
        }

        private int GenerateRandomDigit(Random rng)
        {
            return rng.Next(100) - 50;
        }

        bool RandomBool()
        {
            return rnd.Next(2) == 1;
        }

        void btns_Click(object sender, EventArgs e)
        {
            currentPlayer.changeScore(int.Parse(((Button)sender).Text));
            ((Button)sender).Text = String.Empty;
            ((Button)sender).BackColor = Color.Gray;
            nextTurn();
            hideButtons(((Button)sender).Tag.ToString());
            StartGame();
        }

        private void nextTurn()
        {
            leftPlayer.changeTurn();
            rightPlayer.changeTurn();
        }
        private void hideButtons(string buttonTag)
        {
            uint bX = uint.Parse(buttonTag.Substring(3, 1));
            uint bY = uint.Parse(buttonTag.Substring(4, 1));
            showHiddenButtons(bX, bY, leftPlayer.isMyTurn());
        }
        private void showHiddenButtons(uint X, uint Y, bool XY)
        {
            int xCount, yCount;
            xCount = 0;
            yCount = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bool buttonActive = XY ? ((X == i) ? true : !XY) : ((Y == j) ? true : XY);
                    setButtonState(i, j, buttonActive);
                    xCount += (!XY & buttonActive & (buttons[i, j].Text != "")) ? 1 : 0;
                    yCount += (XY & buttonActive & (buttons[i, j].Text != "")) ? 1 : 0;
                }
            }
            Console.WriteLine("x={0}, y={1}, z={2}", xCount, yCount, (xCount + yCount));
            if (xCount + yCount == 0) GameOver();
        }

        private void GameOver()
        {
            if (leftPlayer.getScore() < rightPlayer.getScore())
                MessageBox.Show(rightPlayer.getName() + " WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
               if (leftPlayer.getScore() > rightPlayer.getScore())
                MessageBox.Show(leftPlayer.getName() + " WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("DEAD HEAT", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setButtonState(int i, int j, bool active)
        {
            buttons[i, j].Enabled = active ? true : false;
            Color buttonColor = colorSet.NONE;
            if (buttons[i, j].Text != "")
            {
                buttonColor = ((int.Parse(buttons[i, j].Text) < 0 ? colorSet.NEGATIVE : colorSet.POSITIVE));
            }
            else
            {
                buttons[i, j].Enabled = false;
            }
            buttons[i, j].BackColor = active ? buttonColor : colorSet.INACTIVE;
        }



    }
}
