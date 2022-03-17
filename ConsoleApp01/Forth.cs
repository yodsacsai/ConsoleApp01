using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{   //ชนิดข้อมูลแบบ Enumeration (Enum)
    enum title
    {
        Mr,Miss,Ms
    }
    class Forth
    {
        static void Main(string[] args)
        {
            int x = 20;
            x = 50;
            const int y = 100;

            Console.WriteLine(title.Miss + " Manee Jaidee");
            Console.WriteLine(" Manee Jaidee");

        }
    }
}
