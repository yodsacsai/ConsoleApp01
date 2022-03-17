using System;

namespace ConsoleApp01
{
    class Frist
    {
        static void ShowA()
        {
            Console.WriteLine("AAA");
        }
        static void Main(string[] args)
        {
            ShowB();
            Console.WriteLine("Hello....");
            ShowA();
            ShowA();
            ShowB();
        }

        static void ShowB()
        {
            Console.WriteLine("BBB");
        }
    }
}
