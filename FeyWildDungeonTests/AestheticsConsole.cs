using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FeyWildDungeon.UI
{
    public class AestheticsConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            var input = Console.ReadKey();
            foreach (char letter in "..........")
            {
                Thread.Sleep(70);
                Console.Write(letter);
            }
            return input;
        }

        public string ReadLine()
        {
            var input = Console.ReadLine();
            for (int i = 0; i < 8; i++)
            {
                Console.Write(".");
                Console.Beep(100, 20);
                Thread.Sleep(70);
            }
            Console.Write("\n");
            return input;
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
