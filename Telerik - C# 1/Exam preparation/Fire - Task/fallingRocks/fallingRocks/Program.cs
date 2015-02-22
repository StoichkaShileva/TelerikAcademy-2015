using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Falling_Rocks
{
    class Game
    {
        public struct Element
        {
            public char character;
            public int x;
            public int y;
            public ConsoleColor color;
            public Element(char character, int x, int y, ConsoleColor color)
            {
                this.character = character;
                this.x = x;
                this.y = y;
                this.color = color;
            }
        }
        static void Drawer(char character, int x, int y, ConsoleColor color, int lifes)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(character);
            Console.SetCursorPosition(21, 1);
            Console.WriteLine("Lifes: {0}", lifes.ToString());

        }
        static void Main(string[] args)
        {
            int lifes = 5;
            Random random = new Random();
            Element player = new Element();
            player.character = '0';
            player.x = 25;
            player.y = 29;
            player.color = ConsoleColor.Green;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 50;
            Drawer(player.character, player.x, player.y, player.color, lifes);
            char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
            bool colided = false;
            List<Element> fallingRocks = new List<Element>();
            while (true)
            {
                if (lifes == 0)
                {
                    Console.Clear();
                    Console.WriteLine("End");
                    break;
                }
                // Add random 3 rocks
                // Change random.next(1,2) to random.next (1,9) for extreme difficulty :D
                for (int i = 0; i < random.Next(1, 2); i++)
                {
                    fallingRocks.Add(new Element(rocks[random.Next(rocks.Length - 1)], random.Next(2, 47), 3, ConsoleColor.White));
                }
                // Change their position
                for (int i = 0; i < fallingRocks.Count; i++)
                {
                    if (fallingRocks[i].y == 29)
                    {
                        fallingRocks.RemoveAt(i);
                    }
                    else
                    {
                        fallingRocks[i] = new Element(fallingRocks[i].character, fallingRocks[i].x, fallingRocks[i].y + 1, fallingRocks[i].color);
                    }
                }

                // Check for collision

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) { Console.ReadKey(true); }
                    if (pressedKey.Key == ConsoleKey.LeftArrow && player.x > 1)
                    {
                        player.x--;
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow && player.x < 48)
                    {
                        player.x++;
                    }
                }
                Console.Clear();
                foreach (Element rock in fallingRocks)
                {
                    if (rock.x == player.x && rock.y == 29)
                    {
                        colided = true;
                    }
                    Drawer(rock.character, rock.x, rock.y, rock.color, lifes);
                }
                if (colided)
                {
                    lifes--;
                    fallingRocks.Clear();
                    Console.Clear();
                    Console.WriteLine("Shit, you failed, Lifes - 1");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                    colided = false;
                }
                Drawer(player.character, player.x, player.y, player.color, lifes);
                // Increase number in Sleep() to change difficulty
                Thread.Sleep(150);
            }
        }
    }
}