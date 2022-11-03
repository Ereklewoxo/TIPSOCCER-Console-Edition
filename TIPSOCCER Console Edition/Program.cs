using System;
using System.Collections.Generic;

namespace TIPSOCCER_Console_Edition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            var originalColor = Console.ForegroundColor;
            Console.Clear();
            Random rnd = new Random();
            int nextLevel = 0;
            var levelList = new List<string> { "Soccer", "Tennis", "Acrobatic" };
            int roundCount = 1;
            int enemyTeamScore = 0;
            int userTeamScore = 0;
            bool userUltraWin = false;
            bool enemyUltraWin = false;
            bool userWantsToPlay = true;
            int secretTeam = 1;
            int userTeam = 0;
            string ballOut = "The ball is out";
            Console.WriteLine("   TIPSOCCER\nConsole Edition");
            //choose your team
            do 
            { 
                Console.Write("\nChoose your team\n1");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(" BLUES   ");
                Console.ForegroundColor = originalColor;
                Console.Write("2 ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REDS");
                Console.ForegroundColor = originalColor;
                var teamChoice = Console.ReadLine().ToLower();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                if (teamChoice == "1" || teamChoice == "blues" || teamChoice == "blue" || teamChoice == "b")
                { 
                    userTeam = 1; 
                    Console.Write("You are ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("BLUES");
                }
                else if (teamChoice == "2" || teamChoice == "reds" || teamChoice == "red" || teamChoice == "r")
                {   
                    userTeam = 2; 
                    Console.Write("You are ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("REDS");
                }
                else if (teamChoice == secretTeam.ToString())
                {
                    userTeam = 3;
                    Console.Write("You unlocked secret team ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("CYAN");
                }
                else
                {                    
                    secretTeam++;
                    Console.WriteLine("Invalid input, try again");
                }
            } while (userTeam == 0);
            Console.ForegroundColor = originalColor;
            do
            {
                Console.Write($"\nRound {roundCount} - ");
                Console.WriteLine(levelList[nextLevel]);
                int num = rnd.Next(100);
                Console.WriteLine("Your Options Are\n1 Miwola\n2 Fint\n3 Shoot");
                var action = Console.ReadLine().ToLower();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                //soccer
                if (nextLevel == 0)
                {
                    switch (action)
                    {
                        case "1":
                        case "miwola":
                        case "m":
                            Console.WriteLine("You try miwola");
                            if (num < 25)
                            {
                                Console.WriteLine("You fail miserably and concede a goal");
                                enemyTeamScore++;
                            }
                            else if (num < 51)
                            {
                                Console.WriteLine("Your miwola was successful and you score");
                                userTeamScore++;
                            }
                            else if (num < 98)
                            {
                                Console.WriteLine(ballOut);
                            }
                            else if (num == 98)
                            {
                                Console.WriteLine("You dead teamed the enemy, gj");
                                if (enemyTeamScore == 1)
                                {
                                    enemyTeamScore--;
                                    userUltraWin = true;
                                }
                                else if (enemyTeamScore > 0)
                                {
                                    enemyTeamScore--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You got dead teamed, ishh");
                                if (userTeamScore == 1)
                                {
                                    userTeamScore--;
                                    enemyUltraWin = true;
                                }
                                else if (userTeamScore > 0)
                                {
                                    userTeamScore--;
                                }
                            }
                            break;
                        case "2":
                        case "fint":
                        case "f":
                            Console.WriteLine("You try fint");
                            if (num < 35)
                            {
                                Console.WriteLine("Enemy reads you like a book, you concede a goal");
                                enemyTeamScore++;
                            }
                            else if (num < 69)
                            {
                                Console.WriteLine("Your fint was successful and you score");
                                userTeamScore++;
                            }
                            else if (num == 99)
                            {
                                Console.WriteLine("You confused the enemy and they got dead teamed");
                                if (enemyTeamScore == 1)
                                {
                                    enemyTeamScore--;
                                    userUltraWin = true;
                                }
                                else if (enemyTeamScore > 0)
                                {
                                    enemyTeamScore--;
                                }
                            }
                            else
                            {
                                Console.WriteLine(ballOut);
                            }
                            break;
                        case "3":
                        case "shoot":
                        case "s":
                            Console.WriteLine("You try to shoot");
                            if (num < 25)
                            {
                                Console.WriteLine("The ball bounces off the enemy and you concede");
                                enemyTeamScore++;
                            }
                            else if (num < 61)
                            {
                                Console.WriteLine("Unsaveable! you score");
                                userTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine(ballOut);
                            }
                            break;
                        default:
                            Console.Write("You do nothing");
                            if (num == 69)
                            {
                                Console.WriteLine(", but your opponent scores an OWN GOAL");
                                userTeamScore++; 
                            }
                            else
                            {
                                Console.WriteLine(", sucky");
                                enemyTeamScore++; 
                            }
                            break;
                    }
                }
                //tennis
                else if (nextLevel == 1)
                {
                    switch (action)
                    {
                        case "1":
                        case "miwola":
                        case "m":
                            Console.WriteLine("You try miwola");
                            if (num < 49)
                            {
                                Console.WriteLine("You fail miserably and concede a goal");
                                enemyTeamScore++;
                            }
                            else if (num < 96)
                            {
                                Console.WriteLine("Your miwola was successful and you score");
                                userTeamScore++;
                            }
                            else if (num < 98)
                            {
                                Console.WriteLine("You dead teamed the enemy, gj");
                                if (enemyTeamScore == 1)
                                {
                                    enemyTeamScore--;
                                    userUltraWin = true;
                                }
                                else if (enemyTeamScore > 0)
                                {
                                    enemyTeamScore--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You got dead teamed, ishh");
                                if (userTeamScore == 1)
                                {
                                    userTeamScore--;
                                    enemyUltraWin = true;
                                }
                                else if (userTeamScore > 0)
                                {
                                    userTeamScore--;
                                }
                            }
                            break;
                        case "2":
                        case "fint":
                        case "f":
                            Console.WriteLine("You try fint");
                            if (num < 40)
                            {
                                Console.WriteLine("Enemy reads you like a book, you concede a goal");
                                enemyTeamScore++;
                            }
                            else if (num < 99)
                            {
                                Console.WriteLine("Your fint was successful and you score");
                                userTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine("You confused the enemy and they got dead teamed");
                                if (enemyTeamScore == 1)
                                {
                                    enemyTeamScore--;
                                    userUltraWin = true;
                                }
                                else if (enemyTeamScore > 0)
                                {
                                    enemyTeamScore--;
                                }
                            }
                            break;
                        case "3":
                        case "shoot":
                        case "s":
                            Console.WriteLine("You try to shoot");
                            if (num < 48)
                            {
                                Console.WriteLine("The ball bounces off the wall and you concede");
                                enemyTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine("Sniper shot! you score");
                                userTeamScore++;
                            }
                            break;
                        default:
                            Console.Write("You do nothing");
                            if (num == 69)
                            {
                                Console.WriteLine(", but your opponent scores an OWN GOAL");
                                userTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine(", sucky");
                                enemyTeamScore++;
                            }
                            break;
                    }
                }
                //acrobatic
                else if (nextLevel == 2)
                {
                    switch (action)
                    {
                        case "1":
                        case "miwola":
                        case "m":
                            Console.WriteLine("You try miwola");
                            if (num < 20)
                            {
                                Console.WriteLine("You fail miserably and concede a goal");
                                enemyTeamScore++;
                            }
                            else if (num < 46)
                            {
                                Console.WriteLine("Everything and everyone is in enemies' goal, you score");
                                userTeamScore++;
                            }
                            else if (num < 94)
                            {
                                Console.WriteLine(ballOut);
                            }
                            else if (num < 97)
                            {
                                Console.WriteLine("You dead teamed the enemy, gj");
                                if (enemyTeamScore == 1)
                                {
                                    enemyTeamScore--;
                                    userUltraWin = true;
                                }
                                else if (enemyTeamScore > 0)
                                {
                                    enemyTeamScore--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You got dead teamed, ishh");
                                if (userTeamScore == 1)
                                {
                                    userTeamScore--;
                                    enemyUltraWin = true;
                                }
                                else if (userTeamScore > 0)
                                {
                                    userTeamScore--;
                                }
                            }
                            break;
                        case "2":
                        case "fint":
                        case "f":
                            Console.WriteLine("You try fint");
                            if (num < 35)
                            {
                                Console.WriteLine("Enemy reads you like a book, you concede a goal");
                                enemyTeamScore++;
                            }
                            else if (num < 65)
                            {
                                Console.WriteLine("Your fint was successful and you score");
                                userTeamScore++;
                            }
                            else if (num < 98)
                            {
                                Console.WriteLine(ballOut);
                            }
                            else
                            {
                                Console.WriteLine("You confused the enemy and they got dead teamed");
                                if (enemyTeamScore == 1)
                                {
                                    enemyTeamScore--;
                                    userUltraWin = true;
                                }
                                else if (enemyTeamScore > 0)
                                {
                                    enemyTeamScore--;
                                }
                            }
                            break;
                        case "3":
                        case "shoot":
                        case "s":
                            Console.WriteLine("You try to shoot");
                            if (num < 20)
                            {
                                Console.WriteLine("The ball bounces off the enemy and you concede");
                                enemyTeamScore++;
                            }
                            else if (num < 50)
                            {
                                Console.WriteLine("Unsaveable! you score");
                                userTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine(ballOut);
                            }
                            break;
                        default:
                            Console.Write("You do nothing");
                            if (num == 69)
                            {
                                Console.WriteLine(", but your opponent scores an OWN GOAL");
                                userTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine(", sucky");
                                enemyTeamScore++;
                            }
                            break;
                    }
                }
                //score display
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = originalColor;
                Console.WriteLine("\n      The Score Is");
                if (userTeam == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"BLUE TEAM {userTeamScore}");
                }
                else if (userTeam == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"RED TEAM {userTeamScore}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"CYAN TEAM {userTeamScore}");
                }
                Console.ForegroundColor = originalColor;
                Console.Write(" - ");
                if (userTeam == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{enemyTeamScore} BLUE TEAM");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{enemyTeamScore} RED TEAM");
                }
                Console.ForegroundColor = originalColor;
                //ultra clean sheet terms
                if (userTeamScore > 0)
                { enemyUltraWin = false; }
                if (enemyTeamScore > 0)
                { userUltraWin = false; }
                //game outcome checks
                if (enemyUltraWin == true && enemyTeamScore == 5)
                { Console.WriteLine("YOU GOT ULTRA CLEAN SHAT ON"); }
                else if (userUltraWin == true && userTeamScore == 5)
                { Console.WriteLine("YOU WON ULTRA CLEAN SHEET"); }
                else if (userTeamScore == 5 && enemyTeamScore == 0)
                { Console.WriteLine("     CLEAN SHEET WIN"); }
                else if (userTeamScore == 5)
                { Console.WriteLine("         YOU WIN"); }
                else if (enemyTeamScore == 5 && userTeamScore == 0)
                { Console.WriteLine("    CLEAN SHEET LOSER"); }
                else if (enemyTeamScore == 5)
                { Console.WriteLine("          LOSER"); }
                else
                {
                    roundCount++;
                    int noSameLevel = nextLevel;
                    do
                    {
                        nextLevel = rnd.Next(3);
                    } while (noSameLevel == nextLevel);
                    if (nextLevel == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (nextLevel == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (nextLevel == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    }
                    continue;
                }
                //play again
                Console.WriteLine("\n       Play Again?\n     1 Yes      2 No");
                var playAgain = Console.ReadLine().ToLower();
                if (playAgain == "1" || playAgain == "" || playAgain == "y" || playAgain == "yes")
                {
                    Console.ForegroundColor = originalColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    roundCount = 1;
                    enemyTeamScore = 0;
                    userTeamScore = 0;
                    userUltraWin = false;
                    enemyUltraWin = false;
                    nextLevel = 0;
                    Console.Write("   TIPSOCCER\nConsole Edition\n\nNew Game Starts\nYou are ");
                    if (userTeam == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("BLUES");
                        Console.ForegroundColor = originalColor;
                    }
                    if (userTeam == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("REDS");
                        Console.ForegroundColor = originalColor;
                    }
                    if (userTeam == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("CYANS");
                        Console.ForegroundColor = originalColor;
                    }
                }
                else if (playAgain == "2" || playAgain == "no")
                {
                    Console.WriteLine("Anyway, thanks for playin'");
                    userWantsToPlay = false;
                }
                else
                {
                    Console.WriteLine("I'll count that as No");
                    userWantsToPlay = false;
                }
            } while (userWantsToPlay);
        }
    }
}