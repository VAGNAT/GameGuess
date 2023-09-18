using GameGuess.Output.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Output
{
    class ConsoleOutput : IOutput
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
