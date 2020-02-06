using System;
using System.Collections.Generic;

namespace ListSum
{
    class Program
    {
        static void Main(string[] args)
        {
            While_Loop();             
        }
        public static void For_Loop() // using for loop to add elements in an array
        {
            int[] myArray = new int[10000];
            int i, n, sum = 0;

            Console.WriteLine("Find sum of all elements in array");

            Console.Write("Enter the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += myArray[i];
            }
            Console.Write("Sum of all elements stored in the array is : " + sum);
        }
        public static void While_Loop() //using while loop to add up elements in an array
        {
            int[] myArray = new int[10000];
            int i, n, sum = 0;

            Console.WriteLine("Find sum of all items in array");

            Console.Write("Enter the number of items to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                Console.Write("item - {0} : ", i);
                i++;
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += myArray[i];
            }
            Console.Write("Sum of all elements stored in the array is : " + sum);
        }
    }
}
   


