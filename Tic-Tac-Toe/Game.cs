using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Game
    {
        public string[,] boxs = new string[3, 3];
        public int playerTurn = 0;
        public int player1Wins = 0;
        public int player2Wins = 0;

        public string BoxClick()
        {

            if (playerTurn == 1)
            {
                playerTurn = 2;
                return "X";
            }

            playerTurn = 1;
            return "O";
        }

        public void Start()
        {
            playerTurn = 1;
        }


        public void Check(String input)
        {
            if (boxs[0, 0] == input && boxs[0, 1] == input && boxs[0, 2] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else if (boxs[1, 0] == input && boxs[1, 1] == input && boxs[1, 2] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else if (boxs[2, 0] == input && boxs[2, 1] == input && boxs[2, 2] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else if (boxs[0, 0] == input && boxs[1, 0] == input && boxs[2, 0] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else if (boxs[0, 1] == input && boxs[1, 1] == input && boxs[2, 1] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else if (boxs[0, 2] == input && boxs[1, 2] == input && boxs[2, 2] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else if (boxs[0, 0] == input && boxs[1, 1] == input && boxs[2, 2] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else if (boxs[2, 0] == input && boxs[1, 1] == input && boxs[0, 2] == input)
            {
                switch (input)
                {
                    case "X": player1Wins++; playerTurn = 0; break;
                    case "O": player2Wins++; playerTurn = 0; break;
                    default: break;
                }
            }

            else
            {
                int count = 0;

                for (int i = 0; i < boxs.GetLength(0); i++)
                {
                    for (int j = 0; j < boxs.GetLength(1); j++)
                    {
                        if (boxs[i, j] == "")
                        {
                            count++;
                        }
                    }
                }

                if (count >= 9) 
                {
                    playerTurn = 0;
                }
            }
        }
    }
}
