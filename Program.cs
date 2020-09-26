using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
    {
        class Program
        {
            static void Main(string[] args)
            {
                //////  1
                Console.WriteLine("1 ____________________________________________________________");
                //a
                sbyte a1 = 1;
                short a2 = 2;
                int a3 = 3;
                long a4 = 4;
                byte a5 = 5;
                ushort a6 = 6;
                uint a7 = 7;
                ulong a8 = 8;
                char a9 = '9';
                bool a10 = true;
                float a11 = 11.444f;
                double a12 = 12.4;
                decimal a13 = 13*10^5; //десятичное дробное число
                string a14 = "14";
                object a15 = 1;
                //Console.WriteLine("b ____________________________________________________________");
                //b
                //неявное приведение
                a4 = a3;
                a11 = a3;
                a12 = a11;
                a7 = a6;
                a8 = a7;
                //явное приведение
                a9 = (char)a3;
                a8 = (ulong)a4;
                a3 = (int)a11;
                a13 = (decimal)a12;
                a1 = (sbyte)a5;
                //Console.WriteLine("c ____________________________________________________________");
                //c
                int b = 5;
                Object c = b; //упаковка (привести элементы к типу объекта (ссылочному типу))
                int d = (int)c; // распаковка
                Console.WriteLine("d ____________________________________________________________ \n");

                //d
                var temp = 25.15; //переменная инициализируется литералом с плавающей запятой
                Console.WriteLine($"{temp.GetType()}");
                Console.WriteLine("e ____________________________________________________________\n");
                //e
                int? e = null; //переменная типа nullable
                Console.WriteLine(e ?? 15); // возвращает значение операнда, если не равно null 
                Console.WriteLine("не равно null");
                Console.WriteLine("Vika prosto krasotka");

                //////  2
                Console.WriteLine("2 ____________________________________________________________\n");
                //a
                string first = "first";
                string second = "second";
                int result = String.Compare(first, second);// сравнивает два обЪекта string  и возвращает целое число, которое указывает их относительное положение в порядке сортировки (побуквенно)
                Console.WriteLine(result);
                Console.WriteLine("b ____________________________________________________________\n");
                //b
                string str1 = "Строка_1", str2 = "Строка_2", str3 = "Строка_3";
                Console.WriteLine(str1 + str2); // сцепление

                str3 = str1.Substring(0, 8);// копирование первых 8 символов в другую строку
                Console.WriteLine(str3);

                string str4 = "я люблю спать";
                string[] str5 = str4.Split(new char[] { ' ' }); // разделяет строку по заданному элементу (по пробелу)
                Console.WriteLine(str5[0]);
                Console.WriteLine(str4 = str4.Insert(2, " не ")); // вставка подстроки в заданную позицию 
                int ind = str4.Length - 1; // индекс последнего символа
                str4 = str4.Remove(0, 1); // удаление заданной подстроки (с нулевой позиции удаляем один символ)
                Console.WriteLine(str4);
                Console.WriteLine();
                Console.WriteLine("c ____________________________________________________________\n");
                //c
                string s1 = "", s2 = null; //к null нельзя использовать методы 
                Console.WriteLine(s1 + "Привет!\n");
                Console.WriteLine(s2 + "Привет!\n");

                Console.WriteLine("d ____________________________________________________________\n");
                //d
                StringBuilder sb = new StringBuilder("Все хорошо");
                sb = sb.Append(new char[] { '!', '!', '!' }); // добавляет строку, подстроку, массив
                Console.WriteLine(sb.ToString());
                Console.WriteLine();
                sb = sb.Insert(4, " будет "); // вставляет строку, подстроку, массив в указанную позицию
                Console.WriteLine(sb.ToString());
                Console.WriteLine();
                sb = sb.Remove(4, 6); // удаляет указанное количество символов, начиная с определенной позиции индекса
                Console.WriteLine(sb.ToString());
                Console.WriteLine();

                //////  3
                Console.WriteLine("3 ____________________________________________________________\n");
                //a
                int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; //задаем двумерный массив
                Console.WriteLine($"{arr[0, 0]} {arr[0, 1]} {arr[0, 2]}\n{arr[1, 0]} {arr[1, 1]} {arr[1, 2]}\n{arr[2, 0]} {arr[2, 1]} {arr[2, 2]} ");
                Console.WriteLine();
                Console.WriteLine("b ____________________________________________________________");
                //b
                string[] Arr = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday" }; //создаем одномерный массив строк
                foreach (string st in Arr) //цикл, который проходит по всем элементам, которые находятся в массиве
                {
                    Console.Write(st + " ");
                }
                Console.WriteLine($"Длина массива {Arr.Length}"); //выводим длину массива 
                Console.WriteLine("Введите элемент массива который хотите поменять");
                int vv = Convert.ToInt32(Console.ReadLine()); //конвертируем в инт
                Console.WriteLine("Введите новое значение");
                string ww = Console.ReadLine();
                Arr[vv - 1] = ww;
                foreach (string st in Arr)
                {
                    Console.Write(st);
                }
                Console.WriteLine();
                //с
                Console.WriteLine("c ____________________________________________________________\n");
                double[][] ar = new double[3][]; //создаем ступенчатый массив: тип, имя, новый тип, размер (число строк в массиве)
                ar[0] = new double[2]; //доступ оказывается к эл-ам осуществляется только по индексу в квадратных скобках
                ar[1] = new double[3];
                ar[2] = new double[4];
                string sr1 = "Введите значения элементов массива:";
                Console.WriteLine(sr1);
                ar[0][0] = Convert.ToDouble(Console.ReadLine()); //значения массива вводим в консоли
                ar[1][0] = Convert.ToDouble(Console.ReadLine());
                ar[2][0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{ar[0][0]} | {ar[1][0]} | {ar[2][0]}");
                Console.WriteLine();
                Console.WriteLine("d ____________________________________________________________\n");
                //d
                var mas1 = new[] { 1, 2, 3 };
                var str = "mr!";
                Console.WriteLine( mas1[0] + mas1[1] + mas1[2]);
                Console.WriteLine();

                //////  4
                Console.WriteLine("4 ____________________________________________________________\n");
                //a
                ulong x = 12;
                ulong x1 = 112;
                var sTuple = Tuple.Create(5, "name", 'c', "surname", x); //задаем кортеж из 5 элементов


                //b
                Console.WriteLine(sTuple.Item2 + sTuple.Item5); //выводим кортеж на консоль 
                                                                
            //c
                var xxx = sTuple.Item1; //распаковка кортежа (расформировываем)
                Console.WriteLine(xxx);
                //d
                (int, string, char, string, ulong) Tuple1 = (2, "hello", 'i', "ill", 68523);
                Console.WriteLine("Распаковка кортежа:");
                Console.WriteLine($"{Tuple1.Item1} {Tuple1.Item2} {Tuple1.Item3} {Tuple1.Item4} {Tuple1.Item5}");

                if ((sTuple.Item1 == Tuple1.Item1) && (sTuple.Item2 == Tuple1.Item2) && (sTuple.Item3 == Tuple1.Item3) && (sTuple.Item4 == Tuple1.Item4) && (sTuple.Item5 == Tuple1.Item5))
                    Console.WriteLine("Кортежи совпадают");
                else
                    Console.WriteLine("Кортежи не совпадают");
                Console.ReadKey();

                /////// 5 

                Console.WriteLine("5 ____________________________________________________________\n");

                int[] arr1 = { -2, 2, 3, 5, 7, 6 };


               (int, int, int, char) MyFunction(int[] array, string str11) //объявляем функцию, где указываем параметры (строка и массив)
                {       
                    Console.WriteLine(array.Max());
                    Console.WriteLine(array.Min());
                    Console.WriteLine(array.Sum());
                    Console.WriteLine(str11[0]);
                 return (array.Max(), array.Min(), array.Sum(), str11[0]);

                }
                MyFunction(arr1, "QWERTY"); //вызываем локальную функцию с параметрами массива и мы пишем строку, чтобы было в первом элементе

            }
        }
    }
