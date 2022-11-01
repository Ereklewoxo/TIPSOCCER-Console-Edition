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
            uint redTeamScore = 0;
            uint blueTeamScore = 0;
            bool blueUltraWin = false;
            bool redUltraWin = false;
            bool userWantsToPlay = true;
            string ballOut = "The ball is out";
            Console.Write("   TIPSOCCER\nConsole Edition\n\nThe Game Starts\nYou are ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("BLUES");
            Console.ForegroundColor = originalColor;
            do
            {
                Console.WriteLine($"\nRound {roundCount}");
                Console.WriteLine(levelList[nextLevel]);
                int num = rnd.Next(100);
                Console.WriteLine("Your Options Are\n1 Miwola\n2 Fint\n3 Shoot");
                var action = Console.ReadLine().ToLower();
                //soccer
                if (nextLevel == 0) 
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
                                redTeamScore++;
                            }
                            else if (num < 45)
                            {
                                Console.WriteLine("Your miwola was successful and you score");
                                blueTeamScore++;
                            }
                            else if (num < 96)
                            {
                                Console.WriteLine(ballOut);
                            }
                            else if (num < 98)
                            {
                                Console.WriteLine("You dead teamed the enemy, gj");
                                if (redTeamScore == 1)
                                {
                                    redTeamScore--;
                                    blueUltraWin = true;
                                }
                                else if (redTeamScore > 0)
                                {
                                    redTeamScore--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You got dead teamed, ishh");
                                if (blueTeamScore == 1)
                                {
                                    blueTeamScore--;
                                    redUltraWin = true;
                                }
                                else if (blueTeamScore > 0)
                                {
                                    blueTeamScore--;
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
                                redTeamScore++;
                            }
                            else if (num < 65)
                            {
                                Console.WriteLine("Your fint was successful and you score");
                                blueTeamScore++;
                            }
                            else if (num == 99)
                            {
                                Console.WriteLine("You confused the enemy and they got dead teamed");
                                if (redTeamScore == 1)
                                {
                                    redTeamScore--;
                                    blueUltraWin = true;
                                }
                                else if (redTeamScore > 0)
                                {
                                    redTeamScore--;
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
                            if (num < 30)
                            {
                                Console.WriteLine("The ball bounces off the enemy and you concede");
                                redTeamScore++;
                            }
                            else if (num < 70)
                            {
                                Console.WriteLine("Unsaveable! you score");
                                blueTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine(ballOut);
                            }
                            break;
                        default:
                            Console.WriteLine("You do nothing, sucky");
                            redTeamScore++;
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
                            if (num < 45)
                            {
                                Console.WriteLine("You fail miserably and concede a goal");
                                redTeamScore++;
                            }
                            else if (num < 94)
                            {
                                Console.WriteLine("Your miwola was successful and you score");
                                blueTeamScore++;
                            }
                            else if (num < 97)
                            {
                                Console.WriteLine("You dead teamed the enemy, gj");
                                if (redTeamScore == 1)
                                {
                                    redTeamScore--;
                                    blueUltraWin = true;
                                }
                                else if (redTeamScore > 0)
                                {
                                    redTeamScore--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You got dead teamed, ishh");
                                if (blueTeamScore == 1)
                                {
                                    blueTeamScore--;
                                    redUltraWin = true;
                                }
                                else if (blueTeamScore > 0)
                                {
                                    blueTeamScore--;
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
                                redTeamScore++;
                            }
                            else if (num < 97)
                            {
                                Console.WriteLine("Your fint was successful and you score");
                                blueTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine("You confused the enemy and they got dead teamed");
                                if (redTeamScore == 1)
                                {
                                    redTeamScore--;
                                    blueUltraWin = true;
                                }
                                else if (redTeamScore > 0)
                                {
                                    redTeamScore--;
                                }
                            }
                            break;
                        case "3":
                        case "shoot":
                        case "s":
                            Console.WriteLine("You try to shoot");
                            if (num < 49)
                            {
                                Console.WriteLine("The ball bounces off the wall and you concede");
                                redTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine("Sniper shot! you score");
                                blueTeamScore++;
                            }
                            break;
                        default:
                            Console.WriteLine("You do nothing, sucky");
                            redTeamScore++;
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
                            if (num < 16)
                            {
                                Console.WriteLine("You fail miserably and concede a goal");
                                redTeamScore++;
                            }
                            else if (num < 44)
                            {
                                Console.WriteLine("Everything and everyone is in enemies' goal, you score");
                                blueTeamScore++;
                            }
                            else if (num < 92)
                            {
                                Console.WriteLine(ballOut);
                            }
                            else if (num < 97)
                            {
                                Console.WriteLine("You dead teamed the enemy, gj");
                                if (redTeamScore == 1)
                                {
                                    redTeamScore--;
                                    blueUltraWin = true;
                                }
                                else if (redTeamScore > 0)
                                {
                                    redTeamScore--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You got dead teamed, ishh");
                                if (blueTeamScore == 1)
                                {
                                    blueTeamScore--;
                                    redUltraWin = true;
                                }
                                else if (blueTeamScore > 0)
                                {
                                    blueTeamScore--;
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
                                redTeamScore++;
                            }
                            else if (num < 65)
                            {
                                Console.WriteLine("Your fint was successful and you score");
                                blueTeamScore++;
                            }
                            else if (num < 98)
                            {
                                Console.WriteLine(ballOut);
                            }
                            else
                            {
                                Console.WriteLine("You confused the enemy and they got dead teamed");
                                if (redTeamScore == 1)
                                {
                                    redTeamScore--;
                                    blueUltraWin = true;
                                }
                                else if (redTeamScore > 0)
                                {
                                    redTeamScore--;
                                }
                            }
                            break;
                        case "3":
                        case "shoot":
                        case "s":
                            Console.WriteLine("You try to shoot");
                            if (num < 15)
                            {
                                Console.WriteLine("The ball bounces off the enemy and you concede");
                                redTeamScore++;
                            }
                            else if (num < 55)
                            {
                                Console.WriteLine("Unsaveable! you score");
                                blueTeamScore++;
                            }
                            else
                            {
                                Console.WriteLine(ballOut);
                            }
                            break;
                        default:
                            Console.WriteLine("You do nothing, sucky");
                            redTeamScore++;
                            break;
                    }
                }
                //score display
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = originalColor;
                Console.WriteLine("\n      The Score Is");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"BLUE TEAM {blueTeamScore}");
                Console.ForegroundColor = originalColor;
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{redTeamScore} RED TEAM");
                Console.ForegroundColor = originalColor;
                //ultra clean sheet terms
                if (blueTeamScore > 0)
                { redUltraWin = false; }
                if (redTeamScore > 0)
                { blueUltraWin = false; }
                //game outcome checks
                if (redUltraWin == true && redTeamScore == 5)
                { Console.WriteLine("YOU GOT ULTRA CLEAN SHAT ON"); }
                else if (blueUltraWin == true && blueTeamScore == 5)
                { Console.WriteLine("YOU WON ULTRA CLEAN SHEET"); }
                else if (blueTeamScore == 5 && redTeamScore == 0)
                { Console.WriteLine("     CLEAN SHEET WIN"); }
                else if (blueTeamScore == 5)
                { Console.WriteLine("         YOU WIN"); }
                else if (redTeamScore == 5 && blueTeamScore == 0)
                { Console.WriteLine("    CLEAN SHEET LOSER"); }
                else if (redTeamScore == 5)
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
                    redTeamScore = 0;
                    blueTeamScore = 0;
                    blueUltraWin = false;
                    redUltraWin = false;
                    nextLevel = 0;
                    Console.Write("   TIPSOCCER\nConsole Edition\n\nThe Game Starts\nYou are ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("BLUES");
                    Console.ForegroundColor = originalColor;
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





