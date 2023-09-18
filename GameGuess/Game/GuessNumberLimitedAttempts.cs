using GameGuess.Output.Interfaces;
using GameGuess.Resources;
using GameGuess.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Game
{
    internal sealed class GuessNumberLimitedAttempts : GuessNumber
    {
        private const int MAX_ATTEMPTS = 10;
        public GuessNumberLimitedAttempts(IOutputGameMessage output, ISecret<int> secretNumber)
            : base(output, secretNumber) { }

        protected override void Play()
        {
            int count = 0;
            while (true)
            {
                count++;
                _output.WriteInputNumber(START_NUMBER, END_NUMBER);
                string? input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }
                if (!Int32.TryParse(input, out int result))
                {
                    _output.WriteDefectString();
                    count--;
                    continue;
                }
                if (result == _secretNumber.Secret)
                {
                    _output.WriteWin();
                    break;
                }
                if (MAX_ATTEMPTS <= count)
                {
                    _output.WriteLose(count);
                    break;
                }
                if (result > _secretNumber.Secret)
                {
                    _output.WriteLess();
                }
                else
                {
                    _output.WriteMore();
                }
            }
        }
    }
}
