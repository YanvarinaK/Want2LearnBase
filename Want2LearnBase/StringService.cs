using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
   public enum Gender
    {
        Man,
        Woman
    }
    public static class StringService
    {
        public static string GetAddress(string city, string street, string houseNumber, string flatNumber)
        {
            string FullAdress;
            FullAdress = String.Format("г. {0}, ул. {1}, д. {2}, кв. {3}", city, street, houseNumber, flatNumber);
            return FullAdress;
        }

        public static int GetCountContains(string line, char symbol)
        {
            int quantity = 0;
            if (line == null)
            {
                return 0;
            }
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == symbol)
                {
                    quantity++;
                }
            }

            return quantity;
        }

        public static int GetCountContains(string line, string word)
        {
            int quantity;
            string newLine = line.Replace(word, "");
            quantity = (line.Length - newLine.Length) / word.Length;
            return quantity;

        }

        public static string StringToNormal(string line, char seporator)
        {
            line = line.Trim(seporator);
            string DuplicateSep = new string(seporator, 2);
            string sep = new string(seporator, 1);
            while (line.Contains(DuplicateSep))
            {
                line = line.Replace(DuplicateSep, sep);
            }
            return line;
        }

        public static string GetSubString(string line, int IndexStart, int IndexEnd)
        {
            string SubString = string.Empty;
            for (int i = IndexStart; i <= IndexEnd; i++)
            {
                SubString = SubString + line[i];

            }
            return SubString;
        }

        public static int[] GetIndexSeparator(string Line, char Seporator)
        {

            int count = GetCountContains(Line, Seporator);
            int[] ArrayInd = new int[count];
            for (int i = 0, j = 0; i < Line.Length; i++)
            {
                if (Line[i] == Seporator)
                {
                    ArrayInd[j] = i;
                    j++;
                }
            }
            return ArrayInd;
        }

        public static string[] MySplit(string line, char seporator)
        {
            if (line == null || line == String.Empty)
            {
                return null;
            }

            line = StringToNormal(line, seporator);
            int[] IndexesSeporators = GetIndexSeparator(line, seporator);
            int countWords = IndexesSeporators.Length + 1;
            string[] resultArray = new string[countWords];

            resultArray[0] = GetSubString(line, 0, IndexesSeporators[0] - 1);
            resultArray[resultArray.Length - 1] = GetSubString(line, IndexesSeporators[IndexesSeporators.Length - 1] + 1, line.Length - 1);
            for (int i = 0, j = 1; i < IndexesSeporators.Length - 1; i++, j++)
            {
                resultArray[j] = GetSubString(line, IndexesSeporators[i] + 1, IndexesSeporators[i + 1]);
            }
            return resultArray;
        }

        public static void ToLowerCase(ref string WordFirst, ref string WordSecond)
        {
            WordFirst = WordFirst.ToLower();
            WordSecond = WordSecond.ToLower();
        }

        private static void SortCharArray(char[] Array)
        {
            char Temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        Temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Temp;
                    }
                }
            }
        }

        public static bool IsAnagram(string wordFirst, string wordSecond)
        {
            bool IsAnagram;
            ToLowerCase(ref wordFirst, ref wordSecond);
            char[] WordFirst = wordFirst.ToCharArray();
            char[] WordSecond = wordSecond.ToCharArray();
            SortCharArray(WordFirst);
            SortCharArray(WordSecond);
            string FirstWord = new string(WordFirst);
            string SecondWord = new string(WordSecond);
            IsAnagram = String.Compare(FirstWord, SecondWord) == 0 ? true : false;
            return IsAnagram;
        }

        private static string ReverseString(string word)
        {
            char[] Word = word.ToCharArray();
            Array.Reverse(Word);
            string RevWord = new string(Word);
            return RevWord;
        }

        public static bool IsPalindrome(string word)
        {
            if (word == null || word == String.Empty)
            {
                return false;
            }
            word = word.ToLower();
            string ReverseWord = ReverseString(word);
            bool Palindrome = word == ReverseWord;
            return Palindrome;
        }

        public static string Welcome(string fullname, Gender gender)
        {
            string ResultWelcome = String.Empty;
            if (gender == Gender.Man)
            {
                ResultWelcome = String.Format("Уважаемый {0}, добро пожаловать!", fullname);
            }
            else
            {
                ResultWelcome = String.Format("Уважаемая {0}, добро пожаловать!", fullname);
            }
            return ResultWelcome;
        }
    }
}
