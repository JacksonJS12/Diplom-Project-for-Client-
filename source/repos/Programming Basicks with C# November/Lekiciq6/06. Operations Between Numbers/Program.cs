using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            // + - * -> "{N1} {operation} {N2} = {резултат} - {even/ odd}"
            // / -> o	"{N1} / {N2} = {резултат:F2}" 
            // & - > o	"{N1} % {N2} = {остатък}"
            //ако делим на 0 -> o	"Cannot divide {N1} by zero"
            double result = 0.0;
            if (operation == '+' || operation == '-' || operation == '*')
            {
                string evenOrOdd = "odd";
                if(operation == '+')
                {
                    result = num1 + num2;
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                }
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
;                }

                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else if (num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (operation == '/')
            {
                result = 1.0 * num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result:F2}");
            }
            else 
            {
                result = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {result}");
            }
        }
    }
}
