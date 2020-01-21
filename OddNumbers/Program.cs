using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            OddNumbers();
        }
        public static void OddNumbers()
        {
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                        continue;
                    Console.WriteLine(i);
                }

            }
    }
}
