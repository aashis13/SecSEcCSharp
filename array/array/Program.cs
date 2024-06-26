using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] num = {1, 2, 3, 4, 5};
            int[] num1 = new int[] {1, 2, 3, 4};
            int[] num2 = new int[3] { 1, 2, 3 };
            string[] s3 = new string[] { "hello", "world", "C#" };
            for (int i = 0;i < 5; i++)
            {

                Console.WriteLine(num[i]);
            }
            foreach(int i in num)
            {
                Console.WriteLine(num1[i]);
            }

            Console.ReadLine();
        }
    }
}