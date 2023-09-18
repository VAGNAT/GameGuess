using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Output.Interfaces
{    
    internal interface IOutputGameMessage : IOutput
    {
        void WriteDefectString();
        void WriteGuessNumber(int startNumber, int endNumber);
        void WriteInputNumber(int startNumber, int endNumber);
        void WriteLess();
        void WriteMore();
        void WriteNewGame();        
        void WriteWin();
        void WriteLose(int countAttempt);
    }
}
