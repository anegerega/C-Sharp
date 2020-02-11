using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            AskAgain:
            Console.Write("Type a word:");
            string word = Console.ReadLine();
            char[] newWord = word.ToCharArray();
            Array.Reverse(newWord);
            string reversedWord = new string(newWord);
            string upreservedword = reversedWord.ToUpper();
            string upword = word.ToUpper();
            if (upreservedword == upword)
            {
                Console.WriteLine("Yes, this word is Palindrome!");
                goto Continueasking;
            }
            else
            {
                Console.WriteLine("Sorry, this word is not Palindrome");
                goto Continueasking;
            }
            Continueasking:
            Console.WriteLine("Do you want to continue? (Enter Yes or No)");
            string decide = Console.ReadLine();
            string decided = decide.ToUpper();
            if (decided == "YES")
            {
                goto AskAgain;
            } else 
            if (decided == "NO")
            {
                Console.WriteLine("Thank you for banking with us!");
            }
            Console.ReadLine();
        }
    }
}
