using System;
using System.Collections.Generic;

namespace ElementOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>()
            {
                "Angela",
                "Nwazuosa",
                "Egerega",
                "Mary",
                "Elizabeth"

            };
            Console.Write("List...\n");
            foreach (string list in list1)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine("Find this item in the list");
            string userItem =  Console.ReadLine();
            if (list1.Contains(userItem) == true)
            {
                Console.WriteLine("Item exists!");
            }
            else
            {
                Console.WriteLine("Item does not exist!");
            }
        }
    }
}
