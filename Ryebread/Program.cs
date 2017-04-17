using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryebread
{
    public class Program
    {
        // as reference: https://www.juanantonioripoll.es/practice-exercises-c-sharp/practice-exercises-c-sharp-lesson-1-first-contact-with-c-sharp.aspx
        public static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
            Console.ReadKey();
        }

        public void Run()
        {
            #region First contact with C#
            //ShowHelloOnTheScreen();
            //SumTwoNumbers();
            //DivideTwoNumbers();
            //MultipleOperations();
            //MultiplyUsingVariables();
            //MultiplicationWithThreeNumbers();
            //DisplayTheFourOperationsAndRemainder();
            //MultiplicationTable();
            //DisplayAverage();
            //EquivalentOperations();
            //AskForAge();
            //Formats();
            //DisplayRectangle();
            //Degrees();
            #endregion

        }

        #region First contact with C#
        public void ShowHelloOnTheScreen()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Elitsa!");
        }

        public void SumTwoNumbers()
        {
            Console.WriteLine(12 + 13);
        }

        public void DivideTwoNumbers()
        {
            Console.WriteLine(24 / 5);
        }

        public void MultipleOperations()
        {
            Console.WriteLine(-1 + 3 * 5);
            Console.WriteLine((24 + 5) % 7);
            Console.WriteLine(15 + (-4) * 6 / 11);
            Console.WriteLine(2 + 10 / 6 * 1 - 7 % 2);
        }

        public void MultiplyUsingVariables()
        {
            Console.WriteLine("Enter a number for multiplier:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number for multiplicand:");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a * b;
            Console.WriteLine("The result: " + result);
        }

        public void MultiplicationWithThreeNumbers()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            Console.Write("Enter the first number to multiply: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number to multiply: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number to multiply: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine("The result from {0} * {1} * {2} is {3}", firstNumber, secondNumber, thirdNumber, result);
        }

        public void DisplayTheFourOperationsAndRemainder()
        {
            int a = 0;
            int b = 0;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
        }

        public void MultiplicationTable()
        {
            int number = 0;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }


        }

        public void DisplayAverage()
        {
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int average = 0;
            Console.Write("Enter the first number: ");
            one = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first number: ");
            two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first number: ");
            three = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first number: ");
            four = Convert.ToInt32(Console.ReadLine());
            average = (one + two + three + four) / 4;
            Console.WriteLine("\nAverage of {0}, {1}, {2} and {3} is {4}", one, two, three, four, average);
        }

        public void EquivalentOperations()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0} + {1}) * {2} = {3}", a, b, c, ( a + b ) * c);
            Console.WriteLine("{0} * {1} + {2} * {1} = {3}", a, c,b, a * c + b * c);
        }

        public void AskForAge()
        {
            int age = 0;
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look younger than {0}!", age);
        }

        public void Formats()
        {
            int number = 0;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            //n n n n
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");

            Console.WriteLine();
            
            //nnnn
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);

            Console.WriteLine("\n");

            //n n n n 
            Console.WriteLine("{0} {0} {0} {0}", number);

            //nnnn
            Console.WriteLine("{0}{0}{0}{0}", number);




        }

        public void DisplayRectangle()
        {
            int number = 0;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
        }

        public void Degrees()
        {
            int celsius = 0;
            int kelvin = 0;
            int fahrenheit = 0;
            Console.Write("Enter a degree in Celsius : ");
            celsius = Convert.ToInt32(Console.ReadLine());
            kelvin = celsius + 273;
            fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine("Kelvin -> {0}", kelvin);
            Console.WriteLine("Fahrenheit -> {0}", fahrenheit);


        }
        #endregion

    }
}
