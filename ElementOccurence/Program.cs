using System;
using System.Collections.Generic;

namespace ElementOccurence
{
    class Program
    {
        public static string YourItem { get; private set; }

        static void Main(string[] args)
        {
        AskAgain:
            Console.WriteLine("Enter your list of items and separate each item with a comma (,): ");
            string new_string = Console.ReadLine();
            string[] YourList = new string[] { " " };
            YourList = new_string.Split(',');

            Console.Write("Now tell us which item are you looking for: ");
            string word = Console.ReadLine();

            foreach (string YourItem in YourList)
            {
                if (YourItem == word)
                {
                    Console.WriteLine(word + " exists in your list");
                }
            }

            int testfound = 0;
            foreach(string i in YourList)
            {
                if(i == word)
                {
                    testfound = +1; 
                }
            }
            if (testfound == 0) Console.WriteLine("Entry not found.");

            Console.WriteLine("Do you want to search through another list? Enter Yes or No");
            string decide = Console.ReadLine().ToUpper();
            if(decide == "YES")
            {
                goto AskAgain;
            }
            else
            {
                Console.WriteLine("Thank You!");
            }
        }
    }

}

