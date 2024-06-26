using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "hello";
            string name2 ="world";
            Console.WriteLine(name + "" +name2);
            Console.WriteLine(string.Concat(name, "", name2));
            Console.WriteLine("This is {0}, {1}", name, name2);
            // string interpolation
            Console.WriteLine($"This is {name}, {name2}");

            Console.WriteLine(name[0]);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
           // int index = name[1];
            Console.WriteLine(name.IndexOf("h"));

            String s ="This is c sharp training";
            // s.Substring
            int index = s.IndexOf("c");
            Console.WriteLine(s.Substring(index));
            Console.WriteLine(s.Replace("c", "c#"));
            Console.WriteLine(s.Length);

            string s1 = "This is \" 2nd semester Class ";
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
