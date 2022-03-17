using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    class Fifth
    {
        static void Main(string[] args)
        {
            string name;
            int year_born;
            int age;

            Console.Write("Enter name : ");
            name = Console.ReadLine();//ค่าที่ป้อนเป็นสตริงเสมอ
            Console.Write("Enter year born : ");
            //year_born = Convert.ToInt32(Console.ReadLine());
            int.TryParse(Console.ReadLine(),out year_born);

            //age = 2022 - year_born;
            age = DateTime.Now.Year - year_born;
            
            Console.WriteLine("++++++++++++++++");
            Console.WriteLine("Your name is : {0}",name);
            Console.WriteLine("Your age is : {0}",age);





        }
    }
}
