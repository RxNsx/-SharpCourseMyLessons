 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ArraysCollections
{
    class Program
    {

        //Присваивание стринг и занчений в массив array
        static void ShowArray(string name, params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}", array[i]);
            }
        }

        static void Main(string[] args)
        {
            ShowArray("Numbers: ", 1, 2, 3, 4, 5, 6, 7, 8, 9);










        }


        //Пример присваивания значения в массив с помощью метода
        static void ShowArray(params int[] array)
        { 
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}", array[i]);
            }
        }
        static void MethodNumbersToArray ()
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            //Delay

            Console.ReadKey();
        }


        //Пример присваивания массивов в методы
         static int[] ModifyArray(int [] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * modifier;
            }

            return array;

            static void ArrayModify()
            {
                int[] myArray = { 1, 2, 3, 4, 5 };

                myArray = ModifyArray(myArray, 5);

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("{0},", myArray[i]);
                }
            }

        }

        static void ArraysUncorrect ()
        {

            //Никогда так не нужно делать

            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2030, 2);
            myArray.SetValue(2031, 3);
            myArray.SetValue(2042, 4);

            //Определение индексов массива

            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}"); // Начальный индекс массива одномерного
            Console.WriteLine();
            Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}"); // Конечный индекс массива


            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine(myArray.GetValue(i));
            }
            Console.WriteLine();
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(myArray.GetValue(i));
            }



            Console.WriteLine();
            foreach (var currency in myArray)
            {
                Console.WriteLine(currency);
            }
        }

        static void JaggedArrays ()
        {
            //Зубчатые массивы JaggedArray

            int[][] jaggedArray = new int[4][]; //объявляется 4 строки
            jaggedArray[0] = new int[1]; // первая строка - 1 элемент
            jaggedArray[1] = new int[3]; // вторая строка - 3 элемента 
            jaggedArray[2] = new int[2]; // третья строка - 2 элемента
            jaggedArray[3] = new int[4]; // четвертая строка - 4 элемента

            Console.WriteLine("Enter a numbers for a jagged arrays");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);

                }


            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Printing Elements of Jaddeg Arrays");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }

                Console.WriteLine();

            }

        }

        static void MultiDimensional ()
            {
                //Многомерные массивы (в основном двухмерные массивы, бывают и трёхмерные)

                //1 2 3 4

                //1 2 3
                //4 5 6
                //7 8 9

                //Двухмерный массив может содержать x строчек и y столбцом (по факту матрица)

                int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

                foreach (var currency in r1)
                {
                    Console.WriteLine(currency);
                }

                for (int i = 0; i < r1.GetLength(0); i++)
                {
                    for (int j = 0; j < r1.GetLength(1); j++)
                    {
                        Console.Write($"{r1[i, j]} ");
                    }
                    Console.WriteLine();

                }
                Console.ReadLine();
            }
        
        static void StackQueue ()
        {
            //Правила на добавление и изменения элементов
            //Первый элемент называется Stack
            //Второй элемент называется Queue

            //Stack - абстрактный тип данных, налогает определенные правила, не предписывает как можно его организовать или использовать.
            //Stack - (ADT) - Abstract Data Type
            //Связанный список - не данные в массиве, указывает один файл на другой.

            //Stack - Реализует LIFO - Last-in First-out (Тот который последним пришел, уходит первым) (Пример с тарелками)

            /*
             * Push -  Для добавления элемента наверх
             * Pop - Забрать элемент сверху
             * Peek - Для получения элемента без добавления или убавления его из коллекции массива (для того чтобы просто посмотреть элемент)
            */

            //Queue 

            //Queue - Реализует FIFO - First-in First-out (Первый пришел, первый ушёл) (Очередь)

            /*
             * Enqueue - Добавляет элемент в конец очереди;
             * Dequeue - Убирает элемент из очереди;
             * Peek - Посмотреть элемент который пришел в очередь без его удаления;
             */

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(4);
            stack.Push(8);
            Console.WriteLine($"Should view a 8: {stack.Peek()}");


            Console.WriteLine(stack.Pop());
            Console.WriteLine();

            foreach (var currency in stack)
            {
                Console.WriteLine(currency);
            }

            //ОТЛИЧНЫМ ПРИМЕРОМ СЛУЖАТ ОТМЕНЯЕМЫЕ ОПЕРАЦИИ

            Console.WriteLine();

            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(8);

            Console.WriteLine($"Should view a 1: {queue.Peek()}");


            Console.WriteLine(queue.Peek());

            queue.Dequeue();
            Console.WriteLine("It's a difference");

            Console.WriteLine(queue.Peek());

            Console.WriteLine("Foreach cycle");

            foreach (var currency2 in queue)
            {
                Console.WriteLine(currency2);
            }

        }

        static void DictionaryMethods ()
        {
            //Dictionary - словарь, ассоциативный массив, когда с одним символом ассоцириуется другой или слово
            //Телефонная книга ключ -фамилия, значение - номер телефона

            //с ключом типа INT ассоциируется со значением STRING

            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");




            //передаётся значение по ключу
            string name = people[1];
            Console.WriteLine(name);


            //Вывод ключей словаря (Dictionary)

            var keys = people.Keys;

            Dictionary<int, string>.KeyCollection Keys = people.Keys;

            Console.WriteLine();

            foreach (var item in Keys)
            {
                Console.WriteLine(item);
            }


            //Вывод значений Dictionary (словаря)

            Dictionary<int, string>.ValueCollection Values = people.Values;

            Console.WriteLine();

            foreach (var item2 in Values)
            {
                Console.WriteLine(item2);
            }

            //Итерирование по паре - ключ значение

            foreach (KeyValuePair<int, string> pair in people)
            {
                Console.WriteLine($"Pair Key: {pair.Key} and Pair Value: {pair.Value}");
            }

            //Запрос количества элементов в Dictionary(Словаря)

            Console.WriteLine();

            //Определяем количество пар в словаре

            Console.WriteLine($"Count={people.Count}");



            //Содержит ли Dictionary какой то ключ, Поиск ключа (ИЩЕТСЯ ОООООООООЧЕНЬ БЫСТРО)

            bool containsKey = people.ContainsKey(2);
            Console.WriteLine(containsKey);


            //Работает медленее поиска ключей
            //Заводится тогда, когда мы знаем что  мы хотим вытащить

            bool containsValue = people.ContainsValue("Bob");
            Console.WriteLine(containsValue);

            Console.WriteLine($"Contains key: {containsKey} contains Value: {containsValue}");

            people.Remove(1);

            Console.WriteLine();

            if (people.TryAdd(2, "Elias"))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add");
            }


            Console.WriteLine();

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine(val);
            }

            people.Clear();

            Console.WriteLine(people.Count);








        }

        //Динамически расширяемый массив
        static void ListArraysMethods ()
        {
            //Сначала добавить System.Collection.Generic;

            //Создание массива intList c инициализацией элементов

            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 };

            //Модифицирует Лист, добавляет число 7 в конец значений;
            intList.Add(7);


            // Добавление экземпляров массива типа int в Лист intList
            int[] intArray = { 1, 2, 3 };

            intList.AddRange(intArray);


            //Возвращает значение bool, срабатывает при первом результате который подходит
            if (intList.Remove(1))
            {
                //do
            }
            else
            {
                //donotdo
            }

            //Убирает первый элемент в Листе
            intList.RemoveAt(0);

            //Меняет местами экзмепляры листа
            intList.Reverse();

            //Содержится ли элемент по индексу в скобках
            bool contains = intList.Contains(3);
            Console.WriteLine(contains);

            //Минимальный и максимальный экземпляр листа
            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"{min} {max}");


            //найти индекс первой 2 в массиве Листа
            int indexof = intList.IndexOf(2);

            //Найти последний индекс 2 в массиве Листа
            int lastIndexOf = intList.LastIndexOf(2);

            //Вместо Lenght свойства - свойство Count
            //Обращаемся по индексу

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]}");
            }

            Console.WriteLine();
            foreach (int item in intList)
            {
                Console.Write(item);
            }

        }

        //Методы массивов
        static void ArraysMethods ()
        {
            //Недостаток массивов в том, что количество его элементов ограничено (заданным числом экземпляров типа)

            //Варианты объявления массивов

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //Метод двоичного поиска заданного числа (работает только на упорядоченный массив)
            //BinarySearch работает очень быстро, возвращает индекс соответствующего элемента

            int index = Array.BinarySearch(numbers, 7);

            Console.WriteLine(index);



            int[] copy = new int[10];

            //Копирование (уровня класса) массива numbers, в массив copy, полная длинна масива numbers.Lentgh

            Array.Copy(numbers, copy, numbers.Length);

            //Копирование (уровня экземпляра) массива copy в массив anotherCopy c индекса 0

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);


            //Модифицирует то что мы ему передаем
            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();


            //Делает все значения нулями (обнуляет)
            Array.Clear(copy, 0, copy.Length);

            //Объявление массива а1
            //Массив а1 с 10 элементами (new int[10])

            int[] а1;
            а1 = new int[10]; //инициализация

            //Объявление массива а2 с 5 экзмеплярами типа int (new int[5])

            int[] a2 = new int[5];

            //Объявление массива а3 с указанием 5 экземпляров типа int с указанием каждого элемента массива

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            //Объявление массива а4 с указанием экземпляров типа int (декларация)

            int[] a4 = { 1, 3, 2, 4, 5 };

            //Массив - это коллекция значений;

            //На самом деле обозначается массив типом Array (также является классом)

            Array myArray = new int[5];

            //Другой вид записи типа Array

            Array myArray2 = Array.CreateInstance(typeof(int), 5);


            //Записываем значение 12 в 0 индекс массива

            myArray2.SetValue(12, 0);

            //Выводим значение myArray2 по 0 индексу

            Console.WriteLine(myArray2.GetValue(0));
        }
    }
}