using System;
using System.Collections.Generic;
using System.Text;

namespace Letters
{
    class MoreLetters
    {
        public string GetNewWord(string original, int howmanytimes)
        {
            string result = "";
            for (var x = 0; x < original.Length; x++)
                for (var y = 0; y < howmanytimes; y++)
                    result = result + original[x];
            return result;
        }
    }
}
