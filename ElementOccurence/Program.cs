using System;
using System.Collections.Generic;

namespace ElementOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            AskAgain:
            Console.WriteLine("Enter your list of items and separate each item with a comma (,): ");
            string new_string = Console.ReadLine();
            string[] YourList = new string[] {" "};
            YourList = new_string.Split(',');

            Console.Write("Now tell us which item are you looking for: ");
            string word = Console.ReadLine();
            
            foreach (string YourItem in YourList)
            {
                Console.Write(YourItem + " ");
                if (YourItem == word)
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
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
