using GameGuess.Game.Interfaces;
using GameGuess.Output.Interfaces;
using GameGuess.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Game
{
    internal abstract class Game : IGame
    {
        protected readonly IOutputGameMessage _output;

        public Game(IOutputGameMessage output)
        {
            _output = output ?? throw new ArgumentNullException(nameof(output), "Parameter can't be null");
        }

        public abstract void Start();
    }
}
