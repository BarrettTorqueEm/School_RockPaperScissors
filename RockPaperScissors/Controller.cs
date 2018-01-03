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
    public class Controller
    {
        ConsoleView aView = null;

        public void getHand1(String firstPlayer, String secondPlayer)
        {
            
            aView.PrintText(aCalc.FindWinner1(firstPlayer, secondPlayer));
            aView.PrintText(aCalc.GetArt(aCalc.FindWinner1(firstPlayer, secondPlayer)));

        }
       // public void getArt(String aWinner)
        //{
        //    aView.PrintText(aCalc.GetArt(aWinner));
        //}

        // Creates a ConsoleView
        Calculator aCalc = new Calculator();

         public void Index()
         {
             aView = new ConsoleView(this);

             // Hard codeing to make sure Calculator works
             //String firstPlayer = "Rock";
           

             // This accepts the user input from ConsoleView
             aView.PrintText(" Rock, Paper, Scissors, Lizard, Spock" + "\n");
             aView.getHand();
         }
    }
}
