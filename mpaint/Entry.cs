using System;
using System.Threading;

/*
 * Version History
 * 
 * 
 * 1.0r0 - Paintbrush
 * 1.0r1 - Red, Blue, Green, Black
 * 1.0r2 - Magenta
 * 1.0r3 - Clear Board
 * 1.0r4 - Menu Function/Cleaning up code
 * 1.0r5 - Help Function/Cleaning up code
 * 
 * 
 * 
 */


namespace Moe
{
    public class Entry 
    {
        public static void Main()
        {
            //Max Width is 80



            //Integers
            int x = 10;
            int y = 10;


            //Booleans
            bool On = false;


            //Strings
           


            //Floats



            //Presets & Functions
            Console.ForegroundColor = ConsoleColor.Black;
   


            void Menu()
            {
                Console.WriteLine("################################################################################\n");
                Console.WriteLine("Mario Paint in C#\t\t\t\tH: Help");
                Console.WriteLine("Version 1.0r5 - By Teegan Lutze\t\t\tESC: Clear\n");
                Console.WriteLine("################################################################################\n");
            }

            void Help()
            {
                Console.WriteLine("################################################################################\n");
                Console.WriteLine("\t\t\t\tQ: Blue\n");
                Console.WriteLine("\t\t\t\tW: Red\n");
                Console.WriteLine("\t\t\t\tE: Green\n");
                Console.WriteLine("\t\t\t\tR: Black\n");
                Console.WriteLine("\t\t\t\tT: Magenta\n");
                Console.WriteLine("\t\t\t\tESC: Go back to Board\n");
                Console.WriteLine("################################################################################\n");
            }






            //Main Loop - Actual Stuff


            Menu();
            while (On == false)
            {
              



                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey(true);


                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        x++;
                        Console.SetCursorPosition(x,y);
                        Console.WriteLine("#");

                        break;

                    case ConsoleKey.UpArrow:
                        y--;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("#");

                        break;

                    case ConsoleKey.DownArrow:
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("#");

                        break;

                    case ConsoleKey.LeftArrow:
                        x--;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("#");

                        break;

                    case ConsoleKey.Q:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case ConsoleKey.W:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    case ConsoleKey.E:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;

                    case ConsoleKey.R:
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;

                    case ConsoleKey.T:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Menu();
                        break;

                    case ConsoleKey.H:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Help();
                        break;
                }
            }

        }
    }
}












































