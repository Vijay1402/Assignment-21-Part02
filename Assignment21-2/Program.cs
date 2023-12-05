using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21_2
{
    delegate T Operation<T>(T a, T b);
    class Program
    {
        static T Add<T>(T a, T b) => (dynamic)a + (dynamic)b;
        static T Subtract<T>(T a, T b) => (dynamic)a - (dynamic)b;
        static T Multiply<T>(T a, T b) => (dynamic)a * (dynamic)b;
        static T Divide<T>(T a, T b) => (dynamic)a / (dynamic)b;

        static void Main()
        {
            Operation<int> addDelegate = Add;
            Operation<int> subtractDelegate = Subtract;
            Operation<int> multiplyDelegate = Multiply;
            Operation<int> divideDelegate = Divide;


            Console.Write("Enter the first value: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second value: ");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");


            int choice = int.Parse(Console.ReadLine());
            int result = 0;

            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    Console.WriteLine($"Result of addition: {result}");
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    Console.WriteLine($"Result of subtraction: {result}");
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    Console.WriteLine($"Result of multiplication: {result}");
                    break;
                case 4:
                    result = divideDelegate(num1, num2);
                    Console.WriteLine($"Result of division: {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                    break;
            }
            Console.ReadKey();
        }
    }
}