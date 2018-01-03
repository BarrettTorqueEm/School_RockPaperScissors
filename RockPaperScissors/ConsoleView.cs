// Code by Michael Girard
// 4/1/15 modified 4/7/15
//Modified by Ryan Gallmann 4/11/15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ConsoleView
    {
        private Controller aController = null;

        public void getHand()
        {
            // This String accepts a user input
            String firstPlayer = "";
            Console.WriteLine("Enter Your Choice");
            firstPlayer = Console.ReadLine();

            String secondPlayer = "";

            //This creates a random number 0-4
            Random rnd = new Random();
            int choice = rnd.Next(0, 5);
          
            //This is the computer/secondplayers choice
            if(choice == 0)
            {
                secondPlayer = secondPlayer + "Rock";
                Console.WriteLine("Sheldon chose Rock");
                Console.ReadLine();
            }
            else if(choice == 1)
            {
                secondPlayer = secondPlayer + "Paper";
                Console.WriteLine("Sheldon chose Paper");
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                secondPlayer = secondPlayer + "Scissors";
                Console.WriteLine("Sheldon chose Scissors");
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                secondPlayer = secondPlayer + "Lizard";
                Console.WriteLine("Sheldon chose Lizard");
                Console.ReadLine();
            }
            else if (choice == 4)
            {
                secondPlayer = secondPlayer + "Spock";
                Console.WriteLine("Sheldon chose Spock");
                Console.ReadLine();
            }
            aController.getHand1(firstPlayer, secondPlayer);
        }
        public void PrintText(String aString)
        {
            // This code prints out the result.
            // Console.WindowWidth = 185;
            Console.WriteLine(aString);
            Console.ReadLine();
        }
        public ConsoleView(Controller aController)
        {
            this.aController = aController;
        }
    }
}
