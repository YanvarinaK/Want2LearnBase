using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
    public static class AlphabetService
    {
        public static char[] GetRusAlphabet()
        {
            int size = 66;
            int indexEndSmall = 32;
            int indexOfyo = 6;
            int indexBeginLarge = 33;
            int indexOfYO = 39;

            char[] Alphavit = new char[size];
            for (int i = 0, j = (int)'а'; i <= indexEndSmall; i++, j++)
            {
                if (i == indexOfyo)
                {
                    Alphavit[i] = 'ё';
                    i++;
                }
                Alphavit[i] = (char)(j);
            }
            for (int i = indexBeginLarge, j = (int)'А'; i <= Alphavit.Length - 1; i++, j++)
            {
                if (i == indexOfYO)
                {
                    Alphavit[i] = 'Ё';
                    i++;
                }
                Alphavit[i] = (char)(j);
            }
            return Alphavit;
        }

        public static char[] GetEngAlphabet()
        {
            int size = 52;
            int j = 0;
            char[] Alphabet = new char[size];
            for (char i = 'a'; i <= 'z'; i++, j++)
            {
                Alphabet[j] = i;
            }
            for (char i = 'A'; i <= 'Z'; i++, j++)
            {
                Alphabet[j] = i;
            }
            return Alphabet;
        }

        public static char[] GetArrayOfEngRusLetters()
        {
            char[] EngAlphabet = GetEngAlphabet();
            char[] RusAlphabet = GetRusAlphabet();
            char[] AllLetters = new char[EngAlphabet.Length + RusAlphabet.Length];
            for (int i = 0; i < EngAlphabet.Length; i++)
            {
                AllLetters[i] = EngAlphabet[i];
            }
            for (int i = EngAlphabet.Length, j = 0; i < AllLetters.Length; i++, j++)
            {
                AllLetters[i] = RusAlphabet[j];
            }
            return AllLetters;
        }
    }
}
