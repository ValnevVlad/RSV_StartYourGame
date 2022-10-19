using System;
using System.Collections.Generic;

namespace RSV_StartYourGame_Middle_Level2
{
    class MainClass
    {
        static int K = 19;
        static int Z = 86149;


        static int[] items = new int[K]; // Первоначальное кол-во вещей в сундуке
        static int m = 0; // На сколько уменьшилось предметов после второго открытия

        static int counter = 0; // счетчик количества элементов в массиве

        public static void Main(string[] args)
        {

            for (items[0] = 0; items[0] <= 80; items[0]++)
            {
                for (m = 0; m <= 80; m++)
                {
                    items[1] = items[0] - m;

                    for (int i = 1; i <= K - 2; i++)
                    {
                        items[i + 1] = items[i] + items[i - 1];

                        if (items[i + 1] != Z)
                        {
                            //Console.WriteLine("No: " + items[K - 1] + " m: " + m + " item[0]: " + items[0]);
                            continue;
                        }
                        else
                        {
                            foreach (int item in items)
                            {
                                counter++;
                                Console.WriteLine(counter + ": " + item);
                            }
                            break;
                        }
                    }
                }
            } 
        }
    }
}
