using GameGuess.Output.Interfaces;
using GameGuess.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Game
{
    internal class GuessNumber : Game
    {
        protected const int START_NUMBER = 0, END_NUMBER = 1000;
        protected readonly ISecret<int> _secretNumber;
        protected bool _play = true;
        public GuessNumber(IOutputGameMessage output, ISecret<int> secretNumber)
            : base(output)
        {
            _secretNumber = secretNumber ?? throw new ArgumentNullException(nameof(secretNumber), "Parameter can't be null");
        }

        public override void Start()
        {
            
            while (_play)
            {
                _output.WriteNewGame();
                string? input = Console.ReadLine();
                if (input is null)
                {
                    break;
                }

                switch (input.ToUpper())
                {
                    case "Q":
                        _play = false;
                        break;
                    case "N":
                        GuessSecretNumber();
                        Play();
                        break;
                    default:
                        _output.WriteDefectString();
                        break;
                }
            }
        }

        protected virtual void Play()
        {
            while (true)
            {
                _output.WriteInputNumber(START_NUMBER, END_NUMBER);
                string? input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }
                if (!Int32.TryParse(input, out int result))
                {
                    _output.WriteDefectString();
                    continue;
                }
                if (result == _secretNumber.Secret)
                {
                    _output.WriteWin();
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
        protected void GuessSecretNumber()
        {
            _secretNumber.SetSecret(START_NUMBER, END_NUMBER);
            _output.WriteGuessNumber(START_NUMBER, END_NUMBER);
        }
    }
}
