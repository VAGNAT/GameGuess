using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Secrets
{
    internal interface ISecret<T>
    {
        T Secret { get; }
        void SetSecret(params T[] input);
    }
}
