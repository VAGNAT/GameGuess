using GameGuess.Output.Interfaces;
using GameGuess.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Output
{
    internal sealed class ConsoleOutputGame : IOutputGameMessage
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteDefectString()
        {
            Console.WriteLine(Message.DefectString);
        }

        public void WriteGuessNumber(int startNumber, int endNumber)
        {
            Console.WriteLine($"{Message.GuessNumber}", startNumber, endNumber);
        }

        public void WriteInputNumber(int startNumber, int endNumber)
        {
            Console.WriteLine($"{Message.InputNumber}", startNumber, endNumber);
        }

        public void WriteLess()
        {
            Console.WriteLine(Message.Less);
        }

        public void WriteMore()
        {
            Console.WriteLine(Message.More);
        }

        public void WriteNewGame()
        {
            Console.WriteLine(Message.NewGame);
        }

        public void WriteWin()
        {
            Console.WriteLine(Message.Win);
        }

        public void WriteLose(int count)
        {
            Console.WriteLine($"{Message.Lose}", count);
        }
    }
}
