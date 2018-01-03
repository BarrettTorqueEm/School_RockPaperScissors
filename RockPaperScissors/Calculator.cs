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
    public class Calculator
    {
        public String FindWinner1(String firstPlayer, String secondPlayer)
        {
            // This string calculates the winner
            String aWinner = "";

            if (firstPlayer == "Rock" && secondPlayer == "Scissors") 
            {
                aWinner = "Rock crushes Scissors, You Win!";
            }
            else if (firstPlayer == "Rock" && secondPlayer == "Lizard")  
            {
                aWinner = "Rock crushes Lizard, You Win!";
            }
            else if (firstPlayer == "Rock" && secondPlayer == "Paper") 
            {
                aWinner = "Paper covers Rock, the winner is Sheldon";
            }
            else if (firstPlayer == "Rock" && secondPlayer == "Spock")
            {
                aWinner = "Spock vaporizes Rock, the winner is Sheldon";
            }
            else if (firstPlayer == "Scissors" && secondPlayer == "Paper")
            {
                aWinner = "Scissors cuts Paper, You Win!";
            }
            else if (firstPlayer == "Scissors" && secondPlayer == "Spock")
            {
                aWinner = "Spock smashes Scissors, the winner is Sheldon";
            }
            else if (firstPlayer == "Scissors" && secondPlayer == "Lizard")
            {
                aWinner = "Scissors decapitates Lizard, You Win!";
            }
            else if (firstPlayer == "Scissors" && secondPlayer == "Rock")
            {
                aWinner = "Rock crushes Scissors, the winner is Sheldon";
            }
            else if (firstPlayer == "Paper" && secondPlayer == "Scissors")
            {
                aWinner = "Scissors cuts Paper, the winner is Sheldon";
            }
            else if (firstPlayer == "Paper" && secondPlayer == "Rock")
            {
                aWinner = "Paper covers Rock, You Win!";
            }
            else if (firstPlayer == "Paper" && secondPlayer == "Lizard") 
            {
                aWinner = "Lizard eats Paper, the winner is Sheldon";
            }
            else if (firstPlayer == "Paper" && secondPlayer == "Spock")
            {
                aWinner = "Paper disproves Spock, You Win!";
            }
            else if (firstPlayer == "Lizard" && secondPlayer == "Scissors")
            {
                aWinner = "Scissors decapitates Lizard, the winner is Sheldon";
            }
            else if (firstPlayer == "Lizard" && secondPlayer == "Rock")
            {
                aWinner = "Rock crushes Lizard, the winner is Sheldon";
            }
            else if (firstPlayer == "Lizard" && secondPlayer == "Paper")
            {
                aWinner = "Lizard eats Paper, You Win!";
            }
            else if (firstPlayer == "Lizard" && secondPlayer == "Spock")
            {
                aWinner = "Lizard poisons Spock, You Win!";
            }
            else if (firstPlayer == "Spock" && secondPlayer == "Rock")
            {
                aWinner = "Spock vaporizes Rock, You Win!";
            }
             else if (firstPlayer == "Spock" && secondPlayer == "Paper")
            {
                aWinner = "Paper disproves Spock, the winner is Sheldon";
            }
            else if (firstPlayer == "Spock" && secondPlayer == "Scissors")
            {
                aWinner = "Spock smashes Scissors, You Win!";
            }
            else if (firstPlayer == "Spock" && secondPlayer == "Lizard")
            {
                aWinner = "Lizard poisons Spock, the winner is Sheldon";
            }
            else if (firstPlayer == secondPlayer)
            {
                aWinner = "Draw! Please play again.";
            }
            else
            {
                aWinner = " There was an error with your entry, please input acceptable entry (case sensitive)";
            }
            return aWinner;
        }

        public String GetArt(String aWinner)
        {
            String aArt = "";

            // if rock wins 
            if (aWinner == "Rock crushes Scissors, You Win!" || aWinner == "Rock crushes Lizard, You Win!" || aWinner == "Rock crushes Scissors, the winner is Sheldon" || aWinner == "Rock crushes Lizard, the winner is Sheldon")
            {
                aArt = aArt + "          _______" + "\n";
                aArt = aArt + "      ---'   ____)" + "\n";
                aArt = aArt + "                (___)" + "\n";
                aArt = aArt + "                (___)" + "\n";
                aArt = aArt + "        VK      (__)" + "\n";
                aArt = aArt + "       ---._____(_)" + "\n";
                
            }
            // if scissors wins
            else if (aWinner == "Scissors cuts Paper, You Win!" || aWinner == "Scissors decapitates Lizard, You Win!" || aWinner == "Scissors cuts Paper, the winner is Sheldon" || aWinner == "Scissors decapitates Lizard, the winner is Sheldon")
            {
                aArt = aArt + "         _______" + "\n";
                aArt = aArt + "     ---'   ____)" + "\n";
                aArt = aArt + "               ______)" + "\n";
                aArt = aArt + "           __________)" + "\n";
                aArt = aArt + "  VK      (____)" + "\n";
                aArt = aArt + "    ---.__(___)" + "\n";
            }
            // if Paper wins 
            else if (aWinner == "Paper covers Rock, You Win!" || aWinner == "Paper disproves Spock, You Win!" || aWinner == "Paper covers Rock, the winner is Sheldon" || aWinner == "Paper disproves Spock, the winner is Sheldon")
            {
                aArt = aArt + "          _______" + "\n";                
                aArt = aArt + "      ---'   ____)____" + "\n";                
                aArt = aArt + "                ______)" + "\n";
                aArt = aArt + "                _______)" + "\n";                
                aArt = aArt + "   VK         _______)" + "\n";
                aArt = aArt + "     ---.__________)" + "\n";                
            }
            // if Lizard wins
            else if (aWinner == "Lizard eats Paper, the winner is Sheldon" || aWinner == "Lizard poisons Spock, the winner is Sheldon" || aWinner == "Lizard eats Paper, You Win!" || aWinner == "Lizard poisons Spock, You Win!")
            {
                aArt = aArt + "              _.--._       /|" + "\n";
                aArt = aArt + "            .'()..()`.    / /" + "\n";
                aArt = aArt + "           ( `-.__.-' )  ( (" + "\n";
                aArt = aArt + "            \\        /    \\ \\" + "\n";
                aArt = aArt + "             \\      /      ) )" + "\n";
                aArt = aArt + "           .' -.__.- `.-.-'_.'" + "\n";
                aArt = aArt + ".        .'  /-____-\\  `.-'" + "\n";
                aArt = aArt + "         \\  /-.____.-\\  /-." + "\n";
                aArt = aArt + "          \\ \\`-.__.-'/ /\\|\\|" + "\n";
                aArt = aArt + "         .'  `.    .'  `." + "\n";
                aArt = aArt + "         |/\\/\\|    |/\\/\\|" + "\n";
            }
            // if Spock wins
            else if (aWinner == "Spock smashes Scissors, the winner is Sheldon" || aWinner == "Spock vaporizes Rock, You Win!" || aWinner == "Spock smashes Scissors, You Win!" || aWinner == "Spock vaporizes Rock, the winner is Sheldon")
            {
                aArt = aArt + "       _     " + "\n";
                aArt = aArt + "      (>\\       _  " + "\n"; 
                aArt = aArt + "     (>\\ \\     /<)" + "\n";
                aArt = aArt + "      \\ \\ \\   / /" + "\n";
                aArt = aArt + "      \\ \\ \\ / /<)" + "\n";
                aArt = aArt + "       \\ \\ V / /  " + "\n";
                aArt = aArt + "      /| '   ` |" + "\n";
                aArt = aArt + "     | |       |" + "\n"; 
                aArt = aArt + "     |         |" + "\n";
                aArt = aArt + "     \\         /" + "\n";
                aArt = aArt + "      |       | " + "\n";
                aArt = aArt + "      |       | VK" + "\n";
            }
            else if (aWinner == "Draw! Please play again.")
            {
                aArt = aArt + "     /))   _   _________________       ((\\ " + "\n";
                aArt = aArt + "    / / _ / ` |      You're     |  ,- _ \\ \\ " + "\n";
                aArt = aArt + "   / / / / /`_|      Lucky      |,-\\ \\ \\ \\ \\ " + "\n";
                aArt = aArt + "   | |/ / / / |       Its       | \\ \\ \\ \\| | " + "\n";
                aArt = aArt + "   | / / / / /|        A        |\\ \\ \\ \\ \\ | " + "\n";
                aArt = aArt + "   | | | `'  (|/(|____Draw_____|)\\|  ' | | | " + "\n";
                aArt = aArt + "   |          `\\  \\         /  /,          | " + "\n";
                aArt = aArt + "   \\           |  |         |  |          / " + "\n";
                aArt = aArt + "    \\             |         |            / " + "\n";
                aArt = aArt + "     \\           /          \\           / " + "\n";
                aArt = aArt + "      \\         /            \\         / " + "\n";
                aArt = aArt + "ejm    \\       /              )       / " + "\n";
                aArt = aArt + "       )      /              /       / " + "\n";
                aArt = aArt + "      /                     /       / " + "\n";
            }
            return aArt;
        }
    }
}
