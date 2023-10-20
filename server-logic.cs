using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playagain = true;

            while (playagain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.Write("Choose between ROCK,PAPER,SCISSOR:  ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer choose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;

                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer choose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            break;
                    }

                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Won");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU Won");
                }
                else
                {
                    Console.WriteLine("Match Draw");
                }
                Console.WriteLine("Do you want to play again");
                string loop = Console.ReadLine();
                if (loop == "yes")
                {
                    playagain = true;
                }
                else if (loop == "no")
                {
                    playagain = false;
                }
                else { }
            }
        }
    }
}