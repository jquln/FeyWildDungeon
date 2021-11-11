using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeyWildDungeon.UI
{
    public interface IConsole
    {
        ConsoleKeyInfo ReadKey();
        string ReadLine();
        void Clear();

        void WriteLine(string s);
        void WriteLine(object o);


    }
}
