using System;
using System.Collections.Generic;

namespace ListSum
{
    class Program
    {
        static void Main(string[] args)
        {
            For_Loop();             
        }
        public static void For_Loop() // using for loop to add elements in an array
        {

            Console.WriteLine("Find sum of all items in array");
            Console.Write("Enter the number of items to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];
            int i = 0;
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                if (i < n)
                {
                    Console.Write("element - {0} : ", i);
                    myArray[i] = Convert.ToInt32(Console.ReadLine());
                    sum += myArray[i];
                }               
            }
            Console.Write("Sum of all elements stored in the array is : " + sum);
        }
        public static void While_Loop() //using while loop to add up elements in an array
        {

            Console.WriteLine("Find sum of all items in array");

            Console.Write("Enter the number of items to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());          
            int[] myArray = new int[n];
            int i = 0;

            int sum = 0;
            while (i < n)
            {
                Console.Write("item - {0} : ", i);
                
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += myArray[i];
                i++;
            }
            Console.Write("Sum of all elements stored in the array is : " + sum);
        }
    }
}
   


