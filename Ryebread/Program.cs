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

            #region Flow control
            //PositiveOrNegative();
            //MultiplyIfNotZero();
            //DivideIfNotZero();
            //DisplayTheGreatestNumber();
            //RepeatUntilSomeoneEntersZero();
            //RepeatUntilSomeoneEntersZeroPartTwo();
            //Counter();
            //TimesTable();
            //OddNumbersDescending();
            //DisplaySum();
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
            for (int i = 1; i <= 10; i++)
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
            Console.WriteLine("({0} + {1}) * {2} = {3}", a, b, c, (a + b) * c);
            Console.WriteLine("{0} * {1} + {2} * {1} = {3}", a, c, b, a * c + b * c);
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

        #region Flow control
        public void PositiveOrNegative()
        {
            Console.Write("Write a number you want to check for being positive or negative: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }

        public void MultiplyIfNotZero()
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                Console.Write("Enter another number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int product = a * b;
                Console.WriteLine("The result from multiplying {0} with {1} is {2}", a, b, product);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        public void DivideIfNotZero()
        {
            int a = 0;
            int b = 0;
            int division = 0;

            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number you want to divide the first one: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (b != 0)
            {
                division = a / b;
                Console.WriteLine("The division of {0} and {1} is {2}", a, b, division);
            }
            else
            {
                Console.WriteLine("I cannot divide!");
            }


        }

        public void DisplayTheGreatestNumber()
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.Write("Write first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("\n{0} is the greatest!", a);
            }
            if (b > c && b > a)
            {
                Console.WriteLine("\n{0} is the greatest!", b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine("\n{0} is the greatest!", c);
            }
        }

        public void RepeatUntilSomeoneEntersZero()
        {
            int a = 0;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            while (a != 0)
            {
                Console.WriteLine(10 * a);

                Console.Write("\nEnter a number: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void RepeatUntilSomeoneEntersZeroPartTwo()
        {
            int a = 0;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(10 * a);

                Console.Write("\nEnter a number: ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a != 0);
        }

        public void Counter()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(++i);
            }
        }

        public void TimesTable()
        {
            int a = 0;
            int b = 1;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            while (b <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                b++;
            }
        }

        public void OddNumbersDescending()
        {
            int a = 15;

            while (a >= 7)
            {
                Console.WriteLine(a);
                a = a - 2;
            }
        }

        public void DisplaySum()
        {
            int a = 0;
            int sum = 0;

            do
            {
                Console.Write("\nNumber? ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    sum = sum + a;
                    Console.WriteLine("Total = {0}", sum);
                }
            } while (a != 0);

            Console.WriteLine("\nFinished!");
        }
    #endregion
}
}
