using System;
using System.Reflection.Metadata;

namespace ITVDN_Course_Starter
{
    class Program
    {

        static void Main()
        {
            












        }


        static void RecursionWithArraysElements ()
        {
            //Вывод значения экземпляра типа int массива array array[0]
            //Если счётчик меньше количества элементов, то выводить текущее значение счётчика и выводить элемент массива, счётчик прогнать дальше + рекурсия

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.ReadKey();
            Console.WriteLine();

            int counter = 0;

            ArrayCounter(counter);

            void ArrayCounter(int counter)
            {


                if (counter < myArray.Length)
                {
                    Console.WriteLine($"Current counter is {counter}");
                    Console.WriteLine($"{myArray[counter]}");

                    counter++;


                    ArrayCounter(counter);
                }

            }
        }

        static void RecursionToTwelve ()
        {
            // n = 0
            // Converter(n);

            static void Converter(int n)
            {
                if (n < 20)
                {
                    n++;

                    Console.WriteLine(n);

                    Converter(n);
                }
            }

        }

        static void RecursionPractice ()
        {
            Method(3);

            static void Recursion(int counter)
            {
                counter--;
                Console.WriteLine($"Первая половина метода Recursion {counter}", counter);

                if (counter != 0)
                {
                    Method(counter);
                }

                Console.WriteLine($"Вторая половина метода Recursion {counter}", counter);
            }

            static void Method(int counter)
            {
                Console.WriteLine($"Первая половина метода Method {counter}", counter);

                Recursion(counter);

                Console.WriteLine($"Вторая половина метода Method {counter}", counter);
            }
        }

        static void InOutParametersInMethods ()
        {
            //Если в теле REF метода выполнится изменение значения переменной переданной по ссылке,
            //Её значение изменится везде

            //  static int MethodRef(ref int a)

            //  {
            //  int b = a * 2;
            //  a = 5;
            //  return b;

            //  }

            //  int operandA = 2;

            //  int result = MethodRef(ref operandA);

            //  Console.WriteLine($"{operandA} and {result}");

        }

        static void StringMethondParameters ()
        {
            //if (name == "Fool")
            //{
            //    Console.WriteLine("Недопустимое имя");
            //}

            //string sentence = $"You name is {name}";

            //return sentence;

            //string myName = Console.ReadLine();

            //string sentence = Function(myName);

            //Console.WriteLine(sentence);
        }

        static void StringReturnFunction ()
        {
            int number1 = 1; int number2 = 2;

            string resultString = Comparsion(number1, number2);

            Console.WriteLine(resultString);
        }

        static void CalculatorLightEdition()
        {
            while (true)
            {
                Console.Clear();

                double number1 = 0;
                double number2 = 0;

                try
                {
                    Console.WriteLine("Enter the first number");
                    number1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    number2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Oops exception here");
                    Console.ReadKey();
                    continue;
                }


                char character = '\0';

                Console.WriteLine("Choose your operator: '+', '-', '*', '/'");

                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case '+':
                        {
                            Console.WriteLine();
                            Console.WriteLine(number1 + number2);
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine();
                            Console.WriteLine(number1 - number2);
                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine();
                            Console.WriteLine(number1 * number2);
                            break;
                        }
                    case '/':
                        {
                            if (number1 == 0 || number2 == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("0");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine(number1 / number2);
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Game Over");
                        break;
                }
                Console.WriteLine("Press on keyboard to try again");
                Console.ReadKey();

            }


        }

        static void MethodsVoids()
        {
            //Выполняется сначала метод Main

            //void - ничего - процедура

            //Методы - функции и процедуры
            //Функции возвращают значения
            //Процедуры не возвращают значения
            //Объявление метода оптимизирует код

            //Для создания метода необходимо

            /*
             * 1. Указать тип возвращаемого значения
             *    Если возвращаемого значения нет, то поставить void
             * 2. Выбрать корректное имя метода (инфинитив)
             * 3. Если метод принимает аргументы, обязательно указать их, или оставить () аргументные скобки пустыми
             * 4. Если метод возвращаемое значение, обязательно в теле должно присутствовать слово RETURN, тип возвращаемого значения должен соответствовать
             * типу значения, указанному после слова return;
             */

            // Функция 
            //        static void HelloWorld ()
            //{
            //  Console.WriteLine("Hello World!");
            //}

            //static string MyName(string name)
            //{
            //  string sentence = $"Hello {name}";
            //return sentence;
            //}



        }

        static void DrawRectangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void EndlessCycles()
        {
            while (true)

                for (; ; )

                    do
                    {

                    }
                    while (true);
        }

        static void LoopSpider()
        {

            char character = '\0';

            bool programmingKnowledge = default(bool);

            Console.WriteLine("Press 'r' if you want to turn right or press 'l' to turn left");
            Console.WriteLine();

            for (; ; )
            {

            Start:
                programmingKnowledge = false;
                character = Console.ReadKey().KeyChar;



                switch (character)
                {
                    case 'r':
                        {
                            Console.WriteLine();
                            Console.WriteLine("You're turning right");
                            programmingKnowledge = true;
                            break;
                        }
                    case 'l':
                        {
                            Console.WriteLine();
                            Console.WriteLine("You're turning left");
                            programmingKnowledge = true;
                            break;
                        }
                }
                switch (character)
                {
                    case 'x':
                        {
                            Console.WriteLine();
                            Console.WriteLine("You pressed 'x'");
                            Console.WriteLine("GameOver");
                            goto End;
                        }
                    case 'q':
                        {
                            Console.WriteLine();
                            Console.WriteLine("You pressed 'q'");
                            Console.WriteLine("GameOver");
                            goto End;
                        }
                }
                if (programmingKnowledge)
                {
                    goto Start;
                }

            End:
                break;

            }
        }

        static void RightLeftEndlessCycleFor()
        {
            char character = '\0';

            for (; ; )
            {

                character = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (character)
                {
                    case 'l':
                        {
                            Console.WriteLine("Turn left");
                            continue;
                        }
                    case 'r':
                        {
                            Console.WriteLine("Turn right");
                            continue;
                        }

                }
                Console.WriteLine();
                Console.WriteLine("Game over");
                break;


            }
        }

        static void GuessRedColor()
        {
            //Игра угадай цвет

            const int maxAttemps = 5;
            int attemp = 0;
            string color = "red";

            while (attemp < maxAttemps)
            {
                attemp++;

                Console.WriteLine($"Номер попытки {attemp}");

                string value = Console.ReadLine();

                if (color == value)
                {
                    Console.WriteLine($"Загадываемый цвет {color}");
                }
                else
                {
                    Console.WriteLine("Пробуйте еще раз");
                }
                break;
            }
        }

        static void CoffeeAutomat()
        {

            Console.WriteLine("Введите номер напитка");

            int coffeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ваш выбор напиток номер {coffeeNumber}");

            int price = 0;

            switch (coffeeNumber)
            {
                case 1:
                    price += 40;
                    break;

                case 2:
                    price += 40;
                    goto case 1;

                case 3:
                    price += 100;
                    goto case 1;
                default:
                    Console.WriteLine("Пожалуйста повторите выбор, нажмите 1 2 или 3");
                    break;
            }

            if (price != 0)
            {
                Console.WriteLine($"Внесите {price} рублей за напиток");
            }
            else
            {
                Console.WriteLine("Повторите набор");
            }


        }

        static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        static double Substraction(double number1, double number2)
        {
            return number1 - number2;
        }

        static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        static double Division(double number1, double number2)
        {
            return number1 / number2;
        }

        static bool Boolean(bool a1, bool b1)
        {
            return a1 && b1;
        }

        static string Comparsion(int value1, int value2)
        {
            if (value1 > value2)
            {
                return $"{value1} > {value2}";
            }
            else if (value2 > value1)
            {
                return $"{value2} > {value1}";
            }
            else
            {
                return $"{value2} == {value1}";
            }
        }
    }
}



