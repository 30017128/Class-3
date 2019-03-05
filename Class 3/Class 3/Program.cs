using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter 1 to start");
            int input = int.Parse(Console.ReadLine());

            if(input ==1)
           


            Console.Write("Please enter your first name:  ");
            var firstname = (Console.ReadLine());

            Console.Write("Please enter your last name:  ");
            var lastname = (Console.ReadLine());

            string fullname = firstname + " " + lastname;



            
            

            Console.Write("Please enter your age:  ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your gender:  ");
            string gender = (Console.ReadLine());

            Console.Write("Please enter your address:  ");
            string address = (Console.ReadLine());

            Console.Write("Please enter a number:  ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter another number:  ");
            double num2 = double.Parse(Console.ReadLine());




            Console.WriteLine("Your name is:  " + fullname);
            Console.WriteLine("Your age is:  " + age);
            Console.WriteLine("Your gender is:  " + gender);
            Console.WriteLine("Your address is:  " + address);

            double result;
            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

            result = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);

            result = num1 * num2;
            Console.WriteLine("{0} x {1} = {2}", num1, num2, result);

            result = num1 / num2;
            Console.WriteLine("{0} ÷ {1} = {2}", num1, num2, result);




            
            Console.Read();


            
        }
    }
}
