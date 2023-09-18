using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuess.Secrets
{
    internal class SecretNumber : ISecret<int>
    {
        private int _secret;
        public int Secret => _secret;

        public void SetSecret(params int[] input)
        {
            _secret = new Random().Next(input[0], input[1] + 1);
        }
    }
}
