using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardGame    //Minimax used for ai for ticTacToe https://medium.freecodecamp.org/how-to-make-your-tic-tac-toe-game-unbeatable-by-using-the-minimax-algorithm-9d690bad4b37
    {
        char huPlayer = 'O';
        char aiPlayer = 'X';

        public BoardGame()
        {
        }


        private char[] emptyIndexies(char[] board)
        {
            List<char> myList = board.ToList();
            List<char> filteredList = myList.Where(s => s != 'O' && s != 'X').ToList();

            return filteredList.ToArray();
        }

        public Boolean Winning(char[] board, char player)
        {
            if (
            (board[0] == player && board[1] == player && board[2] == player) ||
            (board[3] == player && board[4] == player && board[5] == player) ||
            (board[6] == player && board[7] == player && board[8] == player) ||
            (board[0] == player && board[3] == player && board[6] == player) ||
            (board[1] == player && board[4] == player && board[7] == player) ||
            (board[2] == player && board[5] == player && board[8] == player) ||
            (board[0] == player && board[4] == player && board[8] == player) ||
            (board[2] == player && board[4] == player && board[6] == player)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Begin EASY

        public int minimaxEasy(char[] newBoard, char player)
        {
            char[] availSpots = emptyIndexies(newBoard);

            List<Move> moves = new List<Move>();

            // loop through available spots
            for (int i = 0; i < availSpots.Length; i++)
            {
                //create an object for each and store the index of that spot 
                Move move = new Move();

                move.setIndex((int)char.GetNumericValue(newBoard[(int)char.GetNumericValue(availSpots[i])]));

                // set the empty spot to the current player
                newBoard[((int)char.GetNumericValue(availSpots[i]))] = player;


                // reset the spot to empty
                newBoard[(((int)char.GetNumericValue(availSpots[i])))] = Char.Parse(move.getIndex().ToString());

                // push the object to the array
                moves.Add(move);
            }

            int bestMove = 0;
            Random rnd = new Random();
            bestMove = rnd.Next(0, moves.Count);
        
            // return the chosen move (object) from the moves array
            if(moves.Count == 0)
            {
                return 0;
            }
            else { 
                return moves[bestMove].getIndex();
            }
        }

        //End EASY

        //Begin MEDIUM

        public int minimaxMedium(char[] newBoard, char player)
        {
            char []availSpots = emptyIndexies(newBoard);

            if (Winning(newBoard, huPlayer))
            {
                return -10;
            }
            else if (Winning(newBoard, aiPlayer))
            {
                return 10;
            }
            else if (availSpots.Length == 0)
            {
                return 0;
            }


            List<Move> moves = new List<Move>();

            // loop through available spots
            for (int i = 0; i < availSpots.Length; i++)
            {
                //create an object for each and store the index of that spot 
                Move move = new Move();

                move.setIndex((int)char.GetNumericValue(newBoard[(int)char.GetNumericValue(availSpots[i])]));

                // set the empty spot to the current player
                newBoard[((int)char.GetNumericValue(availSpots[i]))] = player;

                /*collect the score resulted from calling minimax 
                  on the opponent of the current player*/
                if (player == aiPlayer)
                {
                    int result = minimaxMedium(newBoard, huPlayer);
                    move.setScore(result);
                }
                else
                {
                    int result = minimaxMedium(newBoard, aiPlayer);
                    move.setScore(result);
                }

                // reset the spot to empty
                newBoard[(((int)char.GetNumericValue(availSpots[i])))] = Char.Parse(move.getIndex().ToString());

                // push the object to the array
                moves.Add(move);
            }

            // if it is the computer's turn loop over the moves and choose the move with the highest score
            int bestMove = 0;
            if (player == aiPlayer)
            {
                int bestScore = -10000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].getScore() > bestScore)
                    {
                        bestScore = moves[i].getScore();
                        bestMove = i;
                    }
                }
            }
            else
            {

                // else loop over the moves and choose the move with the lowest score
                int bestScore = 10000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].getScore() < bestScore)
                    {
                        bestScore = moves[i].getScore();
                        bestMove = i;
                    }
                }
            }

            // return the chosen move (object) from the moves array
            return moves[bestMove].getIndex();
        }

        //End MEDIUM

        //Begin Hard

        public Move minimaxHard(char[] newBoard, char player)
        {
            char[] availSpots = emptyIndexies(newBoard);

            Move tempMove = new Move();

            if (Winning(newBoard, huPlayer))
            {
                tempMove.setScore(-10);
                return tempMove;
            }
            else if (Winning(newBoard, aiPlayer))
            {
                tempMove.setScore(10);
                return tempMove;
            }
            else if (availSpots.Length == 0)
            {
                tempMove.setScore(0);
                return tempMove;
            }

            List<Move> moves = new List<Move>();

            // loop through available spots
            for (int i = 0; i < availSpots.Length; i++)
            {
                //create an object for each and store the index of that spot 
                Move move = new Move();

                move.setIndex((int)char.GetNumericValue(newBoard[(int)char.GetNumericValue(availSpots[i])]));

                // set the empty spot to the current player
                newBoard[((int)char.GetNumericValue(availSpots[i]))] = player;

                /*collect the score resulted from calling minimax 
                  on the opponent of the current player*/
                if (player == aiPlayer)
                {
                    Move result = minimaxHard(newBoard, huPlayer);
                    move.setScore(result.getScore());
                }
                else
                {
                    Move result = minimaxHard(newBoard, aiPlayer);
                    move.setScore(result.getScore());
                }

                // reset the spot to empty
                newBoard[(((int)char.GetNumericValue(availSpots[i])))] = Char.Parse(move.getIndex().ToString());

                // push the object to the array
                moves.Add(move);
            }

            // if it is the computer's turn loop over the moves and choose the move with the highest score
            int bestMove = 0;
            if (player == aiPlayer)
            {
                int bestScore = -10000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].getScore() > bestScore)
                    {
                        bestScore = moves[i].getScore();
                        bestMove = i;
                    }
                }
            }
            else
            {

                // else loop over the moves and choose the move with the lowest score
                int bestScore = 10000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].getScore() < bestScore)
                    {
                        bestScore = moves[i].getScore();
                        bestMove = i;
                    }
                }
            }

            // return the chosen move (object) from the moves array
            return moves[bestMove];
        }

        //End HARD

    }
}
