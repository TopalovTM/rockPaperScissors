using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int rndInt;
            bool isPlayingAgain = true;

            while (isPlayingAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Choose between ROCK, PAPER and SCISSORS:");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    rndInt = rnd.Next(1, 4);

                    switch (rndInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }

                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                             
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }

                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer,scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("The player has WON the game!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("The CPU has won the game!");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string answerYN = Console.ReadLine();
                if (answerYN == "y")
                {
                    isPlayingAgain = true;
                    Console.Clear(); 
                }
                else if (answerYN == "n")
                {
                    isPlayingAgain = false;
                }
            }
        }
    }
}
