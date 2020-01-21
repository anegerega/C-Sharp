<<<<<<< HEAD
﻿using System;
using System.Text;
=======
using System;
>>>>>>> aa67e7ccf64318275ea1a32beff05d7a19ec39be

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            ReverseString();
        }
        private static void ReverseString()
        {
            string myWord = "angelaegerega@yahoo.com";
            char[] mysecondword = myWord.ToCharArray();
            Array.Reverse(mysecondword);
            //  var Sb = new StringBuilder();
            foreach (var i in mysecondword)
            {
                //   Sb.Append(myWords);
=======
            Console.WriteLine("Please enter a word");
            string myWord = Console.ReadLine();
            char[] mysecondword = myWord.ToCharArray();
            Array.Reverse(mysecondword);
            foreach (char i in mysecondword)
            {
>>>>>>> aa67e7ccf64318275ea1a32beff05d7a19ec39be
                Console.Write(i);
            }
            // var myStr = Sb.ToString();
            Console.ReadLine();
        }
        public static void Reverse()
        {
            string message = Console.ReadLine();
            char[] strippedmessage = message.ToCharArray();
            Array.Reverse(strippedmessage);
            foreach (var i in strippedmessage)
            {
                Console.Write(i);
                
            }
        }
       
    }
}
