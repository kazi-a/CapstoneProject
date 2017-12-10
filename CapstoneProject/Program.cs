using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CapstoneProject_TicTacToe
{
    class Program
    {
        // ************************************
        // Title: TIC TAC TOE GAME
        // Application Type: (framework – Console)
        // Description: (TIC TAC TOE game is two player game. Therefore, only two user can play at a time. The result someone will win or if no one can match in a single line then it will be draw. Traditionaly Player 1 will paly with "X" and Player 2 will play with "0". Player cannot override any of the sign which already taken. The player or user that succeeds in placing three respective mark (X,0) in Stright line, cross line or diagonal line will be the winner. )
        // Author: Kazi Arafat
        // Date Created: (12/05/2017)
        // Last Modified: (12/10/17)
        // ************************************

        //
        // Global veariable 
        //
        static char[] num = { '0','1','2','3','4','5','6','7','8','9' };
        static int player = 1;
        static int option;
        static int mark;


        static void Main(string[] args)
        {
            do
            {

                Console.Clear();
                Console.WriteLine("Welcome to the TIC TAC TOE Game!!!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Player 1= X and Player 2= 0");
                Console.WriteLine("\n");
               

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 turn");
                }
                else
                {
                    Console.WriteLine("Player 1 turn");
                }
                Console.WriteLine("\n");
                Table();

                //
                // Get option from user 
                //
                option = int.Parse(Console.ReadLine());

                if (num[option] != 'X' && num[option] != '0')
                {
                    if (player % 2 == 0)
                    {
                        num[option] = '0';
                        player++;
                    }
                    else
                    {
                        num[option] = 'x';
                        player++;
                    }

                }
                else
                {
                    Console.WriteLine("Sorry the column {0} is already taken with {1}", option, num[option] );
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait one moment game is loadig again.....");
                    Thread.Sleep(2500);
                }

                mark = FindWinner();
            } 

            while (mark!=1 && mark!=-1);
            {
                Console.Clear();
                Table();

                if (mark == 1)
                {
                    Console.WriteLine("Congratulations! Player {0} has won", (player%2)+1);
                }
                else
                {
                    Console.WriteLine("Match Draw");

                }   
            }
            Console.ReadLine();
        }

        //
        // Create the Table
        //
        private static void Table()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", num[1], num[2], num[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", num[4], num[5], num[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", num[7], num[8], num[9]);
            Console.WriteLine("     |     |      ");
        }

        //
        // Lets Check the winner
        //
        private static int FindWinner()
        {
            #region Stright line Winner 
  
            if (num[1] == num[2] && num[2] == num[3])
            {
                return 1;
            } 
            else if (num[4] == num[5] && num[5] == num[6])
            {
                return 1;
            }   
            else if (num[6] == num[7] && num[7] == num[8])
            {
                return 1;
            }
            #endregion

            #region Cross line Winner       
            else if (num[1] == num[4] && num[4] == num[7])
            {
                return 1;
            }
            else if (num[2] == num[5] && num[5] == num[8])
            {
                return 1;
            } 
            else if (num[3] == num[6] && num[6] == num[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal line Winner
            else if (num[1] == num[5] && num[5] == num[9])
            {
                return 1;
            }
            else if (num[3] == num[5] && num[5] == num[7])
            {
                return 1;
            }
            #endregion

            #region Match Draw 
            else if (num[1] != '1' && num[2] != '2' && num[3] != '3' && num[4] != '4' && num[5] != '5' && num[6] != '6' && num[7] != '7' && num[8] != '8' && num[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }

    }
}
