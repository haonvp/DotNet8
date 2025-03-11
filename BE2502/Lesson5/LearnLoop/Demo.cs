using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoop
{
    class Demo
    {
        public void printNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void printEvenNum(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void printEvenNum1(int n)
        {
            var i = 0;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public void InputStudent()
        {
            Console.WriteLine("Input the name: ");
            var name = Console.ReadLine();
            int age = validateInt("age");
            double lit = validateDouble("lit");
            double math = validateDouble("math");

            var avg = (math + lit) / 2;
            Console.WriteLine($"The name: {name}, age: {age}, average scor: {avg}");
        }

        public int validateInt(String flied)
        {
            Console.WriteLine($"Input the {flied}");
            var checkAge = int.TryParse(Console.ReadLine(), out int age);
            while (!checkAge)
            {
                Console.WriteLine($"{flied} is not correct, input again...");
                checkAge = int.TryParse(Console.ReadLine(), out age);
            }
            return age;
        }

        public double validateDouble(String flied)
        {
            Console.WriteLine($"Input the {flied}");
            var checkDouble = double.TryParse(Console.ReadLine(), out double value);
            while (!checkDouble)
            {
                Console.WriteLine($"{flied} is not correct, intpu again...");
                checkDouble = double.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }
    }
}
