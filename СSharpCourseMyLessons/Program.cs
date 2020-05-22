using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace СSharpCourseMyLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            























        }



        //УПРАВЛЕНИЕ ПОТОКОМ ИСПОЛНЕНИЯ
        /*ОСНОВНЫЕ ПОНЯТИЯ с#
         * ОСНОВНЫЕ ОСНОВЫ C#
         */

        static void HomeWorkProfilewithIMT ()
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

            double IMT = Weight / (Height * Height) * 1000;

            Console.WriteLine($"Your profile: \n" +
                $"Full name: {LastName} {Name} \n" +
                $"Age: {Age} \n" +
                $"Weight: {Weight} \n" +
                $"Height: {Height} \n" +
                $"Body mass index: {IMT} \n");
        }
        static void FormulaGeronaDZ ()
        {
            //Cчитываем забитые числовые значения в экземпляр типа int из консоли указывая аргумент
            //парсинга Console.Readline()

            Console.WriteLine("Enter a 1 st side of triangle digit");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 2 nd side of triangle digit ");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 3 rd side of triangle digit");
            double c = int.Parse(Console.ReadLine());


            Console.WriteLine($"It's your sides digits a:{a}, b:{b}, c:{c}");

            double p = (a + b + c) / 2;
            double s = p * (p - a) * (p - b) * (p - c);

            Console.WriteLine(Math.Sqrt((p * (p - a) * (p - b) * (p - c))));
        }
        static void HomeWork1 ()
        {
            //Console.WriteLine("Hello my friend, what is your name?");
            //string name = Console.ReadLine();
            //string InputSentence = $"So well your name is {name}";
            //Console.WriteLine(InputSentence);
            //Console.Read();

            //string z;
            //Console.WriteLine("Write here 2 number to focus-focus");
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            // string InputNumbers = $"Your numbers are {x} and {y}";
            //Console.WriteLine(InputNumbers);
            //Console.WriteLine("So well we try to rotate each other");

            //присваиваем неизвестной переменной значение x;
            //z = x;

            //присваиваем x значение y;
            //x = y;



            //Console.WriteLine($"A new numbers are x:{x} and y:{z}");

            // int x;
            // Console.WriteLine("Enter a number we'll know his lenght");
            //string number = Console.ReadLine();
            //Console.WriteLine($"Your number lenght is {number.Length}");
        }
        static void DateTimeBasics()
        {
            //Экземпляр now типа DateTime с текущим временем, которое записывается в тип string
            //и выводится через интерполяцию
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}, now{now.Hour}:{now.Minute}");


            //Экземпляр dt типа DateTime с кастомной датой 28 феврля 2016 года
            DateTime dt = new DateTime(2016, 2, 28);
            Console.WriteLine(dt);

            //Добавляем один день к текущему значению экзепляра dt типа DateTima
            DateTime newDt = dt.AddDays(1);

            //newDt возвращает новый экземпляр с измененной датой не меняя самого dt
            Console.WriteLine(newDt);



            //Длительность времени высчитывается типом TimeSpan

            //Разница между одним и другим временем

            TimeSpan ts = now - dt;

            //ts = now.Subtract(dt);

            Console.WriteLine(ts.Days);
        }
        static void ArraysBasics ()
        {
            //массив из 10 интов, где а1 и есть массив
            int[] a1;
            a1 = new int[10];

            //массив из 5 интов
            int[] a2 = new int[5];

            //массив объявляемый одной строчкой c их инициализацией в {}
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            //массив краткой записью сразу инциализирован и сам выделяет память для элементов
            //массива
            int[] a4 = { 1, 3, 2, 4, 5 };


            //приводим значение 4 элемента из массива а4 в экземпляр типа int с названием number
            int number = a4[4];
            Console.WriteLine(number);

            //присваиваем элементу массива а4 с порядковым номером по индеку 4 новое значение
            a4[4] = 6;
            Console.WriteLine(a4[4]);

            //Длина элемента массива, количество элементов в массиве.
            Console.WriteLine(a4.Length);

            //доступ к последнему элементу массиву
            Console.WriteLine(a4[a4.Length - 1]);

            //работаем с типом string как с массивом
            string s1 = "abcdefgh";

            //выводим первый символ экземпляра типа string s1
            char first = s1[0];

            //выводим последний символ значения экземпляра типа стринг s1
            char last = s1[s1.Length - 1];

            Console.WriteLine(first);
            Console.WriteLine(last);

            Console.WriteLine($"First:{first} Last:{last}");

            /*нельзя изменить элемент строчного массива
             * s1[0]='z';
             */

        }
        static void MathMethods ()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9.2));
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine();
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));

        }
        static void PrivedenieTipovUzkihkShirokim ()
        {
            byte b = 3;// 0000 0011
            int i = b;// 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i;// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011;
            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(l);

            float f = i;
            Console.WriteLine(f);

            b = (byte)i;
            Console.WriteLine(b);
            Console.WriteLine();

            int x = 10;
            int result = x / 3;
            Console.WriteLine(result);

            Console.WriteLine();
            double result2 = (double)x / 3;
            Console.WriteLine(result2);

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine(i);
        }
        public void ConsoleAtributesTowork ()
        {
            //Console.WriteLine("Hi please tell me your name");

            //string name = Console.ReadLine();
            //string sentence = $"Your name is {name}";
            //Console.WriteLine(sentence);
            //Console.Read();

            Console.WriteLine("Hi tell me your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            string sentence = $"Your age is {age}";
            Console.WriteLine(sentence);
        }
        static void StringComparsion ()
        {
            //string str1 = "helloworld";
            //string str2 = "helloworld";

            //bool AreEqual = str1 == str2;
            //Console.WriteLine(AreEqual);

            //AreEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            //Console.WriteLine(AreEqual);

            string str1 = "Strasse";
            string str2 = "Straße";

            bool AreEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(AreEqual);
            AreEqual = string.Equals(str1, str2, StringComparison.InvariantCulture);
            Console.WriteLine(AreEqual);
            AreEqual = string.Equals(str1, str2, StringComparison.CurrentCulture);
            Console.WriteLine(AreEqual);
        }
        static void StringInterpolation ()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and i'm {1}", name, age);
            string str2 = $"My name is {name} and i'm {age}";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            string escapeSpace = "My name is \n Vadim";

            Console.WriteLine(escapeSpace);

            string tabulation = "I'm driving \t a car";

            Console.WriteLine(tabulation);

            tabulation = $"I'm fucking {Environment.NewLine}crazy at this moment";

            Console.WriteLine(tabulation);

            string str5 = "I'm John and I'm a \"good programmer\"";
            Console.WriteLine(str5);

            string str6 = "C:\\tmp\\test_file.txt";
            Console.WriteLine(str6);

            string str7 = @"C:\tmp\text_file.txt";
            Console.WriteLine(str7);

            double answer = 42.3;
            //string result = string.Format("{0:d}", answer);
            //string result2 = string.Format("{0:d4}", answer);

            //Console.WriteLine(result);
            // Console.WriteLine(result2);

            string result3 = string.Format("{0:F}", answer);
            string result4 = string.Format("{0:F4}", answer);

            Console.WriteLine(result3);
            Console.WriteLine(result4);

            //string str2 = "My name is " + name + " and i'm " + age;
            //Console.WriteLine(str2);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 0.2;
            result4 = string.Format("{0:P}", money);

            result3 = $"{money:P4}";
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
        static void StringBuilder ()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Vadim");
            sb.AppendLine("!");
            sb.AppendLine("Heelo!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringsMethods ()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "Vadim");

            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "Vadim");

            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "Ebanarot,");
            Console.WriteLine(nameConcat);

            string xnamespace = "helloworld";
            xnamespace = xnamespace.Insert(0, "Hello this is my World, look at your ");
            Console.WriteLine(xnamespace);

            xnamespace = xnamespace.Remove(0, 1);
            Console.WriteLine(xnamespace);

            string replaced = nameConcat.Replace('a', '4');
            Console.WriteLine(replaced);

            string data = "12;28;34;25;64";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[2]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);


            string Vadim = " My name is Vadim ";
            Console.WriteLine(Vadim.Trim());
        }
        static void IsnulloremptyMethod ()
        {
            string str = string.Empty;
            //string Empty = "";//same as


            string Emplty = "";
            string WhiteEmpty = " ";
            string notEmpty = " b";
            string nullString = null;


            //nullString.Contains('a');

            Console.WriteLine("IsNullOrEmpty");


            bool IsNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(WhiteEmpty);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(Emplty);
            Console.WriteLine(IsNullOrEmpty);


            Console.WriteLine();

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(WhiteEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(Emplty);
            Console.WriteLine(isNullOrWhiteSpace);
        }
        static void MethodsOnString()
        {
                        string name = "abracadabra";
        bool containsA = name.Contains('a');
        bool containsE = name.Contains('E');

        Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithabra = name.EndsWith("abra");

        Console.WriteLine(endsWithabra);

            bool startsWithabra = name.StartsWith("abra");

        Console.WriteLine(startsWithabra);

            int indexOfA = name.IndexOf('a', 1);
        Console.WriteLine(indexOfA);

            int LastIndexOfA = name.LastIndexOf('r');
        Console.WriteLine(LastIndexOfA);

            Console.WriteLine(name.Length);

            string substr = name.Substring(5);
        string substr3 = name.Substring(3);
        Console.WriteLine(substr);
            Console.WriteLine(substr3);
        }
        static void KEKW ()
        {
            string name = "abrakadabra";
            bool contansA = name.Contains('a');
            bool contansE = name.Contains('e');

            Console.WriteLine(contansA);
            Console.WriteLine(contansE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }
        static void AreEqualsC ()
        {

            int x = 1;
            int y = 2;

            bool AreEqual = x == y;
            Console.WriteLine(AreEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);

        }
        static void MathOperations ()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;

            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;

            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 4 % 2;
            b = 5 % 2;


            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            //a = a * a * a;

            Console.WriteLine();

            Console.WriteLine(a);

            a = 2 + 2 * 2;

            Console.WriteLine();
            Console.WriteLine(a);

            a *= 2;

            a /= 2;
        }
        static void IncrementDecrementDemo()
        {
                        int x = 1;

        x = x + 1;

            Console.WriteLine(x);


            int y = 1;
        y++;

            Console.WriteLine(y);

            int z = 2;

        z--;
            --z;

            Console.WriteLine(z);

            x += 2;
            Console.WriteLine(x);

            y -= 1;
            Console.WriteLine(y);
        }
    }
}
