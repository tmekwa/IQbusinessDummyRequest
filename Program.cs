using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter NAME:");
            String input = Console.ReadLine();

            Console.WriteLine("Enter AGE:");
            int input1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter GENDER m/f:");
            Char input2 = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            if (input2 == 'm' || input2 == 'M')
                Console.WriteLine("Name of user: " + input + "\nAge: " + input1 + "\nGender: " + "Male");
            else if (input2 == 'f' || input2 == 'F')
                Console.WriteLine("Name of user: " + input + "\nAge: " + input1 + "\nGender: " + "Female");
            else
                Console.WriteLine("Error specifying sex gender");
            Console.ReadKey();
        }
    }
}
