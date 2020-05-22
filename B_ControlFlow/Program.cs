using System;

namespace B_ControlFlow
{
    class Program
    {

            static void Main(string[] args)
        {


     











        }
            static void EnterthesystemLoginPassword3Tries ()
        {
            string password = "qwerty";
            string login = "johnsilver";
            //стартовое число попыток 1
            int tries = 1;


            //если попыток меньше или равно 3 то тогда
            while (tries <= 3)
            {
                Console.WriteLine("Enter login");
                string userlogin = Console.ReadLine();

                Console.WriteLine("Enter password");
                string userPassword = Console.ReadLine();

                //если логин и пароль равен правильному
                //заканчивает сработку если логин и пароль удовлятворяет требованиям
                if (userlogin == "johnsilver" && userPassword == "qwerty")
                {
                    Console.WriteLine("Enter the System");
                    break;
                }

                tries++;

                if (tries == 4)
                {
                    Console.WriteLine("You exceeded the number of avaible");
                }
            }

        }
            static void FactorialsHomeWork()
        {
            Console.WriteLine("Enter a number to factorial");
            double number = double.Parse(Console.ReadLine());
            double degree = number;
            double result;

            switch (number)
            {
                case 1:
                case 0:
                    number = 1;
                    break;
            }


            Console.WriteLine(Math.Pow(number, degree));


        }
            static void SredneeArifmeticheskoe10chisel()
        {
            /*Запросить 10 чисел
 * При введении 0 прекратить
 * При введении 10 числе сбросить
 * Вычислить среднее значение введеных чисел
 */

            //Выделяем число памяти для 10 чиссел в массив
            int[] Numbers = new int[10];
            //Число подсчёта введеных чисел, стартуем с 0
            int InputCount = 0;

            while (InputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                Numbers[InputCount] = number;

                InputCount++;

                if (number == 0)
                {
                    break;
                }

                int sum = 0;
                int count = 0;

                foreach (int n in Numbers)
                {
                    if (n > 0 && n % 3 == 0)
                    {
                        sum += n;
                        count++;
                    }

                }

                double average = (double)sum / count;
                Console.WriteLine(average);
            }
        }
            static void FibonacciZadacha()
            {
                Console.WriteLine("Enter how much you need a Fibonachi numbers");
                int n = int.Parse(Console.ReadLine());

                int[] fibonacci = new int[n];

                int a0 = 0;
                int a1 = 1;

                fibonacci[0] = a0;
                fibonacci[1] = a1;

                for (int i = 2; i < n; i++)

                {
                    int a = a0 + a1;
                    fibonacci[i] = a;


                    // меняем значения чтобы правильно высчитывать значения чисел фибоначчи
                    a0 = a1;
                    a1 = a;

                }


                //значения из фибоначи поступают в CUR

                foreach (int cur in fibonacci)
                {
                    Console.WriteLine(cur);
                }
            }
            static void OtladkaPosikOshibok()
            {
                //Точка остановки, позволяет посмотреть где ошибки идут
                /* F9 cтавит точку остановки
                 * F5 запускает Деббагинг
                 * F10 переключает на следующую строчку
                 * Когда запускается в режиме отладки, программа отснавливается
                 * Видно в какой строчке произошла ошибка
                 */


                Console.WriteLine("Let's calculate the square of a triangle");
                Console.WriteLine("Enter the lenght of side AB");
                //double ab = GetDouble();

                Console.WriteLine("Enter the lenght of side BC");
                //double bc = GetDouble();

                Console.WriteLine("Enter the lenght of side AC");
                //double ac = GetDouble();

                //double p = (ab + bc + ac) / 2;

                //double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
                //Console.WriteLine($"Square of triangle equals {square}");


                //static double GetDouble ()
                {
                    //return double.Parse(Console.ReadLine());
                }
            }
            static void SwitchCaseConstruction()
            {
                //Объединение кейсов, на примере определения сезона)
                //Также есть оператор goto case #

                Console.WriteLine("What's is month now?");

                int month = int.Parse(Console.ReadLine());

                string season = string.Empty;

                switch (month)

                {
                    //Кейсы для Зимы
                    case 1:
                    case 2:
                    case 12:
                        season = "Winter";
                        break;

                    //Кейсы для Весны
                    case 3:
                    case 4:
                    case 5:
                        season = "Spring";
                        break;

                    //Кейсы для Лета
                    case 6:
                    case 7:
                    case 8:
                        season = "Summer";
                        break;

                    //Кейсы для Осени
                    case 9:
                    case 10:
                    case 11:
                        season = "Autumn";
                        break;
                    //хз че эт такое
                    default:
                        throw new ArgumentException("Unexpected number of month");
                }

                Console.WriteLine($"Now is {season}");

                Console.WriteLine();

                //Управляющая конструкция switch_case (замена большого количества if else - конструкций, и работает быстрее

                int weddingYears = int.Parse(Console.ReadLine());

                string name = string.Empty;


                //switch делается на какой то переменной, которая нам интересна

                switch (weddingYears)
                {
                    //случай если переменная 5 (зависит от значения)
                    case 5:
                        name = "Wooden Wedding";
                        //break обязательно
                        break;
                    case 10:
                        name = "Olovyannaya Wedding";
                        break;
                    case 15:
                        name = "Chrystalnaya Wedding";
                        break;
                    case 20:
                        name = "Farforovaya Wedding";
                        break;
                    case 25:
                        name = "Silver Wedding";
                        break;
                    case 30:
                        name = "Pearl Wedding";
                        break;

                    //берется значения отсюда если не подходит ни для одного из кейсов
                    default:
                        name = "Не знаем такого юбилея свыш!";
                        break;
                }
                Console.WriteLine(name);

            }
            static void BreakContinueCycle()
            {
                int[] numbers = { 0, 3, 2, 1, 4, 5, 6, 7, 8, 9 };
                char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Number is {numbers[i]}");

                    for (int j = 0; j < letters.Length; j++)
                    {
                        //если индекс массива с номерами равен индексу массива с символами, закончить внутренний цикл;
                        if (numbers[i] == j)
                        {
                            break;
                        }
                        Console.Write($"{letters[j]}");
                    }
                    Console.WriteLine();

                }





                //Console.ReadLine();

                //Ищем первые 3 пары чисел, которые в сумме дают 0;

                //int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
                //int counter = 0;

                //for (int i = 0; i < numbers.Length; i++)
                //{
                //прерываем работу внешнего условия, когда кол-во значений равно 3
                //if (counter == 3)
                //{ 
                // break;
                //}


                //  for (int j = i + 1; j < numbers.Length; j++)
                //{ 
                //int atI = numbers[i];
                //int atJ = numbers[j];

                //if (atI + atJ == 0)
                //{
                //  Console.WriteLine($"Pair ({atI});({atJ}). Indexes ({i}):({j})");

                //инкрементируем число срабатываний условия
                // counter++;
                // }
                // //прерываем работу внешнего условия, когда кол-во значений равно 3
                //   if (counter == 3)
                //     {
                //           break;
                //         }

                // }
                // }
            }
            static void DoWhileCycle()
            {
                //dowhile циклы
                //Повторять пока не выполнится условие цикла
                //Запрашивать пароль пока не введет верно

                //запрашиваем возраст, пока не будет задано число удовлетворяющее условию, что тебе больше 18-ти лет

                int age = 30;

                while (age < 18)
                {
                    Console.WriteLine("Frist while Loop");
                    Console.WriteLine("What is your age?");
                    age = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Good");

                //когда в цикл нужно зайти хотя бы 1 раз
                /* в таком случае используется цикл do {}
                 * while()
                 */
                //условие проверяется после выполнения цикла
                //в циклах while выполняется проверка до выполнения цикла


                do
                {
                    Console.WriteLine("Do\\While");
                    Console.WriteLine("What is your age?");
                    age = int.Parse(Console.ReadLine());
                }
                while (age < 18);

                //пройтись по массиву

                int[] numbers = { 1, 2, 3, 4, 5 };
                int i = 0;
                while (i < numbers.Length)
                {
                    Console.Write(numbers[i] + " ");
                    i++;
                }

                //инкремент находится внутри while, если мы работаем с массивом
            }
            static void InnerForCycles()
            {
                //ищем пары чисел дающие в сумме 0

                //int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

                //for (int i = 0; i < numbers.Length; i++)
                //{
                //  for (int j = i + 1; j < numbers.Length; j++)
                //{ 
                //int atI = numbers[i];
                //int atJ = numbers[j];

                //if (atI + atJ == 0)
                //{
                //  Console.WriteLine($"Pair ({atI});({atJ}). Indexes ({i}):({j})");
                //}
                //}
                //}

                //int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

                //for (int i = 0; i < numbers.Length - 2; i++)
                //{
                //for (int j = i + 1; j < numbers.Length - 1; j++)
                //{
                //for (int k = j + 1; k < numbers.Length; k++)
                //{
                //int atI = numbers[i];
                //int atJ = numbers[j];
                //int atK = numbers[k];

                //if (atI + atJ + atK == 0)
                //{
                //    Console.WriteLine($"Triplets ({atI}):({atJ}):({atK}) Indexes ({i}):({j}):({k})");
                //}
                //}
                //}
                //}
            }
            static void ForEachСycle()
            {

                //массив типа int
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                //запускаем цикл for c итератором int
                //итератор - элемент предоставляющий доступ к элементам массива (обычно это int i)


                //старт с 0, пока i < количества длины массива (9 единиц), будет прибавляться по 1 за каждую ступень пока не упрется в конечное значение (9)

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(numbers[i] + " ");
                }

                Console.WriteLine();

                for (int g = 0; g < numbers.Length; g++)
                {
                    if (numbers[g] % 2 == 0)
                    {
                        Console.WriteLine(numbers[g] + " ");
                    }
                    else
                    {
                        Console.WriteLine(numbers[g] + " nechetnoe");
                    }
                }

                //когда нам не нужен индексный доступ massive[0], используется цикл for each

                //в переменную val поступают значения из numbers (основного массива 1-9)
                //доступа к индексу нет, доступ сразу к значениям

                foreach (int val in numbers)
                {
                    Console.Write(val + " ");
                }


            }
            static void HomeWorkWithIfElse()
            {
                Console.WriteLine("Enter the first number");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                int y = int.Parse(Console.ReadLine());

                if (x > y)
                {
                    Console.WriteLine($"{x} is the biggest of this numbers");
                }
                else if (x < y)
                {
                    Console.WriteLine($"{y} is the biggest of this numbers");
                }
                else
                {
                    Console.WriteLine($"{x} equals {y}");
                }
            }
            static void IfElseConstruction()
            {
                Console.WriteLine("Enter your Lastname");
                string LastName = Console.ReadLine();

                Console.WriteLine("Enter your name");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter your age in years");
                double Age = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your weight in kilogramms");
                double Weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your height in meters");
                double Height = double.Parse(Console.ReadLine());

                // формула вес (кг) / (рост (м) * рост (м))

                double IMT = Weight / (Age * Height) * 1000;

                Console.WriteLine($"Your profile: \n" +
                    $"Full name: {LastName} {Name} \n" +
                    $"Age: {Age} \n" +
                    $"Weight: {Weight} \n" +
                    $"Height: {Height} \n" +
                    $"Body mass index: {IMT} \n");

                bool isTooLow = IMT <= 18.5;

                //&& логическое И
                bool isNormal = IMT >= 18.5 && IMT < 25;

                //&& логическое И
                bool isAboveNormal = IMT >= 25 && IMT <= 30;

                //> больше 30
                bool isTooFat = IMT > 30;

                bool isFat = isAboveNormal || isTooFat;


                //isfat == true
                //else (isfat == false)

                if (isFat)
                {
                    Console.WriteLine("You'd better lose some weight");
                }
                else
                {
                    Console.WriteLine("You're in a good shape");
                }

                //if (isFat == false)
                if (!isFat)
                {
                    Console.WriteLine("You're definetly not fat!");
                }


                //проверка более чем одного условия

                if (isTooLow)
                {
                    Console.WriteLine("Not enought weiht");
                }
                else if (isNormal)
                {
                    Console.WriteLine("You're okay");
                }
                else if (isAboveNormal)
                {
                    Console.WriteLine("Be careful");
                }

                //если не сработает ни одно из условий
                else
                {
                    Console.WriteLine("You need some weight");
                }



                //условие ИЛИ одно ИЛИ другое ||
                if (isFat || isTooFat)
                {
                    Console.WriteLine("It's time to get on diet");
                }

                //Тернарное выражение
                //Если возраст больше 18, то присваивается первая строчка в description, если нет - то присваивается вторая строчка.
                string description = Age > 18 ? "You can drink alchohol" : "You should get a bit older";

                if (Age > 18)
                {
                    description = "You can drink alcohol";
                }
                else
                {
                    description = "You should get a bit older ";
                }

                Console.WriteLine(description);
            }
        }
    }

  

