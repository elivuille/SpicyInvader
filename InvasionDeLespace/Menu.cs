using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvasionDeLespace
{
    class Menu
    {
        public static int menuPos = 1;
        public static string choice1 = "Jouer";
        public static string choice2 = "Paramètres";
        public static string choice3 = "Quitter";

        public void Main()
        {
            Enemies game = new Enemies();

            ConsoleKeyInfo menuChooser;

            menuColor();
           
            do
            {
                menuChooser = Console.ReadKey(true);
               
                switch (menuChooser.Key)
                {
                    
                    case ConsoleKey.DownArrow:
                        if(menuPos < 3)
                        {
                            menuPos++;
                            menuColor();
                        }
                        else
                        {
                            menuPos = 1;
                            menuColor();
                        }                                            
                        Debug.WriteLine(menuPos);
                        break;
                    case ConsoleKey.UpArrow:
                        if (menuPos > 1)
                        {
                            menuPos--;
                            menuColor();
                        }
                        else
                        {
                            menuPos = 3;
                            menuColor();
                        }
                        Debug.WriteLine(menuPos);
                        break;
                    case ConsoleKey.Enter:
                        switch (menuPos)
                        {
                            case 1:
                                Console.Clear();
                                game.Maingame();
                                break;
                            case 2:
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("L'application va se quitter...");
                                System.Threading.Thread.Sleep(1500);
                                Environment.Exit(0);
                                break;                           
                        }
                        break;
                   
                }

            } while (true);                                                                         
        }

        static void menuColor()
        {
            switch (menuPos)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth -10) / 2, (Console.WindowHeight - 15) / 2);
                    Console.WriteLine(choice1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, Console.WindowHeight / 2);
                    Console.WriteLine(choice2);
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, (Console.WindowHeight + 15) / 2);
                    Console.WriteLine(choice3);
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, (Console.WindowHeight - 15) / 2);
                    Console.WriteLine(choice1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, Console.WindowHeight / 2);
                    Console.WriteLine(choice2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, (Console.WindowHeight + 15) / 2);
                    Console.WriteLine(choice3);
                    break;
                case 3:
                    Console.Clear();
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, (Console.WindowHeight - 15) / 2);
                    Console.WriteLine(choice1);
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, Console.WindowHeight / 2);
                    Console.WriteLine(choice2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth - 10) / 2, (Console.WindowHeight + 15) / 2);
                    Console.WriteLine(choice3);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
