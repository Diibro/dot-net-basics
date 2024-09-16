using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Rock Paper Scissor Game");
            int playerScore = 0, computerScore = 0;
            string compChoice = "", playerChoice;
            bool playAgain = true;
            Random rand = new Random();

            while (playAgain)
            {
                Console.WriteLine("Choose [R] for Rock, [P] for Paper and [S] for scissor or [Q] to quit. ");
                playerChoice = Console.ReadLine().ToUpper();
                if (playerChoice == "Q") break;
                int computerChoiceNumber = rand.Next(1,4);

                switch(computerChoiceNumber)
                {
                    case 1:
                        compChoice = "R";
                        Console.WriteLine("I choose Rock");
                        break;
                    case 2:
                        compChoice = "P";
                        Console.WriteLine("I choose Paper");
                        break;
                    case 3:
                        compChoice = "S";
                        Console.WriteLine("I choose Scissor");
                        break;
                }
                
                if(playerChoice == compChoice)
                {
                    Console.WriteLine("It is a draw");
                    Console.WriteLine("You: " + playerScore + " Me: " + computerScore);
                }
                else if(
                    (playerChoice == "R" && compChoice == "P") || 
                    (playerChoice == "P" && compChoice == "S") ||
                    (playerChoice == "S" && compChoice == "R")
                    )
                {
                    Console.WriteLine("I won");
                    computerScore++;
                    Console.WriteLine("You: " + playerScore + " Me: " + computerScore);
                }
                else if (
                    (playerChoice == "P" && compChoice == "R") ||
                    (playerChoice == "S" && compChoice == "P") ||
                    (playerChoice == "R" && compChoice == "S")
                    )
                {
                    Console.WriteLine("Congs you woooooon!!!!!!!!");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Me: " +  computerScore);
                }else
                {
                    Console.WriteLine("Try again you enter wrong choice..");
                }

            }
        }
    }
}
