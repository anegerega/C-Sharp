using System;

namespace Palindrome
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Type a word:");
            string word = Console.ReadLine();
            char[] newWord = word.ToCharArray();
            Array.Reverse(newWord);
            string reversedWord = new string(newWord);
            if (reversedWord == word)
            {
                Console.Write("It is");
            }
            else
            {
                Console.Write("It is NOT");
            }

            Console.ReadLine();
        }
    }
}
