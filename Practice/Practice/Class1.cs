using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Class1
    {
        public static void Test()
        {
            Console.WriteLine("Test1");
        }
        public static void Test(int a)
        {
            Console.WriteLine("Test2");
        }
        public static void Test(string a, int b)
        {
            Console.WriteLine("Test3");
        }

        public static void Search(string name)
        {
            Console.WriteLine("Search by name");
        }
        public static void Search(int age)
        {
            Console.WriteLine("Search by age");
        }
        public static void Search(string name, int surname)
        {
            Console.WriteLine("Search by name and surname");
        }
    }
}
