using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qweqweqwe
{
    internal class menu
    {
        private string prop;
        private string[] options;
        private int y;


        public menu(string _prop, string[] _options, int Y)
        {
            prop = _prop;
            options = _options;
            y = Y;
        }
        public int MakeMenu()
        {
            int index = 0;
            int posY;

            while (true)
            {
                posY = y;
                Console.SetWindowSize(100, 40);
                Console.CursorVisible = false;
                Console.SetCursorPosition((Console.WindowWidth / 2) - (prop.Length / 2), posY);
                Console.WriteLine(prop);
                for (int i = 0; i < options.Length; i++)
                {
                    posY++;
                    if (i == index)
                    {
                        Console.SetCursorPosition((Console.WindowWidth / 2) - (prop.Length / 2), posY);
                        Console.WriteLine("> {0}", options[i]);
                    }
                    else
                    {
                        Console.SetCursorPosition((Console.WindowWidth / 2) - (prop.Length / 2), posY);
                        Console.WriteLine("  {0}", options[i]);
                    }
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo press = Console.ReadKey();
                    switch (press.Key)
                    {
                        case (ConsoleKey.UpArrow):
                            if (index > 0) { index--; }
                            break;
                        case (ConsoleKey.DownArrow):
                            if (index < options.Length - 1) { index++; }
                            break;
                        case (ConsoleKey.Enter):
                            return index;
                    }
                }
            }

        }
    }
}
