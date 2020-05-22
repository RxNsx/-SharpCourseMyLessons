using System;
using System.Linq;

namespace ZadachiPraktika
{
    class Program
    {
        /// <summary>
        /// ПОльзователь вводит сумму денег, вводит процент ставки, и количество дней своего вклада. Всё рассчитать и вывести
        /// </summary>

        static void Main(string[] args)
        {

            

        }   
        


            static void PracticeArraysNumberOne ()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }

            int[] numericTries = { 4, 5, 6, 7, 13, 12, 15, 19, 21 };

            foreach (int good in numericTries)
            {
                Console.Write(good + " ");
            }


            Console.WriteLine();

            Array.Reverse(numericTries);

            foreach (int bad in numericTries)
            {
                Console.Write(bad + " ");
            }
        }
            static void PaintSquareWithUserLengthandWidth ()
        {
            Console.WriteLine("Enter the lenght");
            int lenght = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter the width");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Your lenght:{lenght} and width:{width}");
            Console.WriteLine();

            for (int i = 0; i < width; i++)
            {
                Console.Write("*");

                for (int r = 0; r < lenght; r++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
            static void SquarePainting ()
        {
            Console.WriteLine("Enter a number of string of square");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");

                for (int j = 0; j < number; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
            static void Razborforcycle ()
        {
            int counter = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("55 ");

                for (int r = 0; r < 4; r++)
                {
                    Console.Write("12 44 ");
                }

                Console.WriteLine($"Number of count {counter}");
                counter++;
            }
        }
            static void GameGuesstheColor ()
        {
            int tries = 1;
            string color = "green";

            while (tries <= 3)
            {
                Console.WriteLine("Enter a color");
                string userColor = Console.ReadLine();

                if (color == userColor)
                {
                    Console.WriteLine("Congratulation!");
                    break;
                }

                tries++;

                if (tries == 4)
                {
                    Console.WriteLine("A lot of tries. You Lose!");
                }
            }
        }
            static void StepenChisla()
            {
                //Пользователь вводит число. Выведите на экран квадрат этого числа, куб этого числа.
                int number = int.Parse(Console.ReadLine());
                int exponent1 = 2;
                int exponent2 = 3;

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(Math.Pow(number, i));
                }
            }
            static void ZadachkaSlojenieUmnojenie()
            {
                Console.WriteLine("Enter the first number");
                int FirstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                int SecondNumber = int.Parse(Console.ReadLine());

                int result1 = FirstNumber * SecondNumber;
                int result2 = FirstNumber + SecondNumber;

                Console.WriteLine($"The multiplication equals {result1}");
                Console.WriteLine($"The addition equals {result2}");

            }
            static void TenRazWelcome()
            {
                //вывести you're welcome 10 раз, или сколько запросит пользователь


                string Welcome = "You're welcome";

                int numbers = int.Parse(Console.ReadLine());

                for (int i = 0; i < numbers; i++)
                {
                    Console.WriteLine(Welcome);
                }

                Console.WriteLine();
            }
        }
    }

