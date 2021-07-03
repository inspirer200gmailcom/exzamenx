using System;
using System.Collections.Generic;
using System.Text;

namespace red
{
    class Program
    {
        struct Elo
        {
            public int Delivery { get; set; }
            public int Value { get; set; }
            public static int FindMinElement(int a, int b)
            {
                if (a > b) return b;
                if (a == b) { return a; }
                else return a;
            }

            //Ввод элементов 
            static void Main(string[] args)
            {
                
                //Console.ForegroundColor = ConsoleColor.White;
                //Console.ForegroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                int i = 0;
                int j = 0;
                int n;

                Console.WriteLine("Введите количество A");
                n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];

                Console.WriteLine("Введите количество B");
                int m = Convert.ToInt32(Console.ReadLine());
                int[] b = new int[m];
                Elo[,] C = new Elo[n, m];

                Console.WriteLine("Ввод a[i]");
                for (i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ввод b[i]");
                for (j = 0; j < b.Length; j++)
                {
                    b[j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();

                Console.WriteLine("Ввод C[i][j]");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        Console.Write("a[{0},{1}] = ", i, j);
                        C[i, j].Value = Convert.ToInt32(Console.ReadLine());
                    }
                }
                i = j = 0;

                ////Выполняется цикл пока значение не примет false
                while (i < n && j < m)
                {
                    try
                    {
                        if (a[i] == 0) { i++; }
                        if (b[j] == 0) { j++; }
                        if (a[i] == 0 && b[j] == 0) { i++; j++; }
                        C[i, j].Delivery = Elo.FindMinElement(a[i], b[j]);
                        a[i] -= C[i, j].Delivery;
                        b[j] -= C[i, j].Delivery;
                    }
                    catch { }
                }
                Console.Clear();


               //вывод массива 
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        if (C[i, j].Delivery != 0)
                        {
                            Console.Write("({0})", C[i, j].Delivery);
                        }
                        else
                            Console.Write("====", C[i, j].Delivery);
                    }
                    Console.WriteLine();
                }

                int ResultFunction = 0;
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        ResultFunction += (C[i, j].Value * C[j, i].Delivery);

                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Ответи = {0}", ResultFunction);
                i = 0;
                j = 0;
                int[] u = new int[n];
                int[] v = new int[m];
                Console.ReadLine();
            }
        }
    }
}
