

using System.Security.Cryptography;

namespace TrieuLeUyen_31231020264
{
    internal class Chuong_08
    {
        private static void Main(string[] args)
        {
            ///input a string and print it
            string s1 = "Hi minh hong co bic @123 456 la gi";
            System.Console.WriteLine(s1);
            ///find the length of a string without using a library function.
            int c = Length(s1);
            Console.WriteLine($"Word count is: {c}");
            ///separate individual characters from a string
            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[i] + "  ");
            }
            Console.WriteLine();
            ///print individual characters of the string in reverse order
            for (int i = s1.Length -1; i >= 0; i--)
            {
                Console.Write(s1[i]);
            }
            Console.WriteLine();
            ///count the total number of words in a string
            int a = Countword(s1);
            Console.WriteLine($"Number of word is: {a}");
            /// count the number of alphabets, digits and special characters in a string
            int b = CountDigit(s1);
            Console.WriteLine($"The number of digits are: {b}");
            int d = CountAlph(s1);
            Console.WriteLine($"The number of alphabets are: {d}");
            int e = Length(s1) - CountBlank(s1);
            Console.WriteLine($"The number of symbols are: {d}");
            ///count the number of vowels or consonants in a string.
            int f = CountNum(s1);
            int g = CountAlph(s1) - CountNum(s1);
            Console.WriteLine($"The number of vowels are: {f}");
            Console.WriteLine($"The number of consonants are: {g}");
            ///check whether a given substring is present in the given string
            string s2 = "Hi minh hong co bic @123 456 la gi";
            System.Console.WriteLine(s2);
        }
        /// <summary>
        /// find the length of a string without using a library function.
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        static int Length(string s1)
        {
            int c = 0;
            foreach (char a in s1)
            {
                c++;
            }
            return c;
        }
        /// <summary>
        /// count the total number of words in a string
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        static int Countword(string s1)
        {
            int a = 0;
            for (int i = 0;i < s1.Length;i++)
            {
                if (s1[i] == ' ' && s1[i + 1] != ' ')
                {
                    a++;
                }
            }
            return a + 1;
        }
        /// <summary>
        /// count the number of alphabets, digits and special characters in a string
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        static int CountDigit (string s1)
        {
            int a = 0;
            for (int i = 0;i < s1.Length;i++)
            {
                if (char.IsDigit(s1[i]))
                {
                    a++;
                }
            }
            return a;
        }
        static int CountAlph (string s1)
        {
            int b = 0;
            for (int i = 0; i < s1.Length;i++)
            {
                if (char.IsLetter(s1[i]))
                {
                    b++;
                }
            }
            return b;
        }
        static int CountBlank(string s1)
        {
            int a = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ' ' && s1[i + 1] != ' ')
                {
                    a++;
                }
            }
            return a;
        }
        /// <summary>
        /// count the number of vowels or consonants in a string.
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        static int CountNum (string s1)
        {
            int g = 0;
            for (int i = 0;i < s1.Length ; i++)
            {
                if (s1[i] == 'a' || s1[i] == 'u' || s1[i] == 'e' || s1[i] == 'o' || s1[i] == 'i' || s1[i] == 'U' || s1[i] == 'E' || s1[i] == 'O' || s1[i] == 'A' || s1[i] == 'I')
                {
                    g++;
                }
            }
            return g;
        }
        static void Check (string s)
        {

        }
    }
}
