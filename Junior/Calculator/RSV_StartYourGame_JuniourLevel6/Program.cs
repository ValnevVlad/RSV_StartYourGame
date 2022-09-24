using System;
using System.Collections.Generic;
using System.Linq;

namespace RSV_StartYourGame_JuniourLevel6
{
    class MainClass
    {
        static int[] trajectory1 = {1, 3, 4, 3, 6, 3, 6, 1, 4, 2, 5, 5, 3, 5, 1};
        static int[] trajectory2 = {1, 6, 4, 1, 4, 4, 6, 5, 1, 2, 2, 1, 2, 3, 5};

        static int[] properties = { 9, 20, 33, 17, 37, 53 };

        static List<float> figures_distance = new List<float>();

        public static void Main(string[] args)
        {

            // Определяем тип фигуры (круг, треугольник или прямоугольник)
            for (int i = 0; i < trajectory1.Length; i++)
            {
                int figure = trajectory1[i];

                if (figure >= 1 & figure <= 3)
                {
                    // Определяем размер круга
                    int cicle_length = properties[figure-1];

                    // l = 2πr ===> r = l/2π
                    float radius = (float)(cicle_length / (2 * Math.PI));
                    //float radius = (float)Math.Round(cicle_length / (2 * 3.14), 6);
                    float circle_distance = (float)Math.Round(2 * radius, 6);
                    Console.WriteLine(figure + " It's Circle " + cicle_length + "=Length " + circle_distance);
                    figures_distance.Add(circle_distance);
                }
                else if(figure > 3 & figure <= 5)
                {
                    // Определяем размер треугольника
                    int triangle_side = properties[figure-1];

                    // h = a√3 / 2
                    float triangle_height = (float)Math.Round(triangle_side * Math.Sqrt(3) / 2, 6);
                    //float triangle_height = (float)Math.Round(triangle_side * 1.732 / 2, 6);
                    Console.WriteLine(figure + " It's Triangle " + triangle_side + "=side " + triangle_height);
                    figures_distance.Add(triangle_height);
                }
                else if (figure == 6)
                {
                    float rectangle_side = (float)properties[figure-1];
                    Console.WriteLine(figure + " It's Rectangle " + rectangle_side + "=side " + rectangle_side);
                    figures_distance.Add(rectangle_side);
                }
                else
                {
                    Console.WriteLine("Exception!");
                }
            }
            Console.WriteLine("figures_distance length: " + figures_distance.Count);
            float common_distance = (float)Math.Round(figures_distance.Sum(),6);
            Console.WriteLine("Distance: " + common_distance);
        }
    }
}
