using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class FormGame : Form
    {
        private readonly Game _game;
        public FormGame(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_game.playerTurn == 0)
            {
                Clear();
                _game.Start();
                outputInfo.Text = "X's Turn";
            }
        }

        private void Clear()
        {
            for (int i = 0; i < _game.boxs.GetLength(0); i++)
            {
                for (int j = 0; j < _game.boxs.GetLength(1); j++)
                {
                    _game.boxs[i, j] = "";
                }
            }

            box1a.Text = "";
            box1b.Text = "";
            box1c.Text = "";
            box2a.Text = "";
            box2b.Text = "";
            box2c.Text = "";
            box3a.Text = "";
            box3b.Text = "";
            box3c.Text = "";

        }

        private void box1a_Click(object sender, EventArgs e)
        {
            if (box1a.Text == "" && _game.playerTurn != 0)
            {
                box1a.Text = _game.BoxClick();
                _game.boxs[0, 0] = box1a.Text;
                _game.Check(_game.boxs[0, 0]);
                Score();
            }
        }

        private void box1b_Click(object sender, EventArgs e)
        {
            if (box1b.Text == "" && _game.playerTurn != 0)
            {
                box1b.Text = _game.BoxClick();
                _game.boxs[0, 1] = box1b.Text;
                _game.Check(_game.boxs[0, 1]);
                Score();
            }
        }

        private void box1c_Click(object sender, EventArgs e)
        {
            if (box1c.Text == "" && _game.playerTurn != 0)
            {
                box1c.Text = _game.BoxClick();
                _game.boxs[0, 2] = box1c.Text;
                _game.Check(_game.boxs[0, 2]);
                Score();
            }
        }

        private void box2a_Click(object sender, EventArgs e)
        {
            if (box2a.Text == "" && _game.playerTurn != 0)
            {
                box2a.Text = _game.BoxClick();
                _game.boxs[1, 0] = box2a.Text;
                _game.Check(_game.boxs[1, 0]);
                Score();
            }
        }

        private void box2b_Click(object sender, EventArgs e)
        {
            if (box2b.Text == "" && _game.playerTurn != 0)
            {
                box2b.Text = _game.BoxClick();
                _game.boxs[1, 1] = box2b.Text;
                _game.Check(_game.boxs[1, 1]);
                Score();
            }
        }

        private void box2c_Click(object sender, EventArgs e)
        {
            if (box2c.Text == "" && _game.playerTurn != 0)
            {
                box2c.Text = _game.BoxClick();
                _game.boxs[1, 2] = box2c.Text;
                _game.Check(_game.boxs[1, 2]);
                Score();
            }
        }

        private void box3a_Click(object sender, EventArgs e)
        {
            if (box3a.Text == "" && _game.playerTurn != 0)
            {
                box3a.Text = _game.BoxClick();
                _game.boxs[2, 0] = box3a.Text;
                _game.Check(_game.boxs[2, 0]);
                Score();
            }
        }

        private void box3b_Click(object sender, EventArgs e)
        {
            if (box3b.Text == "" && _game.playerTurn != 0)
            {
                box3b.Text = _game.BoxClick();
                _game.boxs[2, 1] = box3b.Text;
                _game.Check(_game.boxs[2, 1]);
                Score();
            }
        }

        private void box3c_Click(object sender, EventArgs e)
        {
            if (box3c.Text == "" && _game.playerTurn != 0)
            {
                box3c.Text = _game.BoxClick();
                _game.boxs[2, 2] = box3c.Text;
                _game.Check(_game.boxs[2, 2]);
                Score();
            }
        }

        private void Score()
        {
            outputScoreX.Text = ("X: " + _game.player1Wins);
            outputScoreO.Text = ("O: " + _game.player2Wins);
            switch (_game.playerTurn) 
            {
                case 0: outputInfo.Text = "Press Start"; break;
                case 1: outputInfo.Text = "X's Turn"; break;
                case 2: outputInfo.Text = "O's Turn"; break;
            }
        }
    }
}
