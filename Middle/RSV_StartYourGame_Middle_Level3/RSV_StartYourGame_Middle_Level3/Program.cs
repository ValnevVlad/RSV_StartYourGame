using System;

namespace RSV_StartYourGame_Middle_Level3
{
    class MainClass
    {

        /// <summary>
        ///
        // Компания, в которой ты работаешь, разрабатывает 2D-платформер.Тебе
        // необходимо написать программу, которая будет автоматически
        // подсчитывать минимальное количество энергии, необходимое для прохождения уровня.
           
        // Уровень 2D-платформера состоит из N островков.Чтобы пройти уровень,
        // игроку необходимо перебраться от одного края экрана до
        // другого(слева направо). На прыжок с одного островка на соседний игрок
        // расходует |y2 – y1| энергии, где y1 и y2 – положение островков
        // по оси у.Также у игрока есть суперспособность, он может перепрыгнуть
        // через один островок, но на это у него затрачивается в 3 раза больше
        // энергии, чем на обычный прыжок.Известны координаты всех островков
        // по оси у, от левого до правого края.Определи минимальное количество
        // энергии, которое понадобится игроку для прохождения уровня.
           
           
        // Входные данные
           
        // В первой строке записано количество островков N.
        // Во второй строке координаты островков по оси у (натуральные числа).
           
           
           
        // Выходные данные
           
        // Минимальное количество энергии, которое понадобится игроку для прохождения уровня.
        ///
        /// </summary>

        static int N = 14; // Количество островков
        static int[] islands = new int[] { 14, 8, 1, 10, 9, 5, 11, 3, 4, 4, 11, 10, 8, 9 };

        static int min_energy = 0;

        

        public static void Main(string[] args)
        {
            for (int i = 0; i <= islands.Length - 2; i++)
            {
                min_energy = min_energy + Math.Abs(islands[i + 1] - islands[i]);
            }
            Console.WriteLine("Минимальная энергия без использования суперсилы: " + min_energy);

            
            min_energy = 0;
            for (int i = 0; i <= islands.Length - 2; i++)
            {
                int jump_without_pwr = Math.Abs(islands[i + 1] - islands[i]);
                if (i != islands.Length - 2)
                {
                    int jump_with_pwr = 3 * Math.Abs(islands[i + 2] - islands[i]);
                    

                    if (jump_with_pwr <= jump_without_pwr)
                    {

                        min_energy = min_energy + jump_with_pwr;
                    }
                    else
                    {
                        min_energy = min_energy + jump_without_pwr;
                    }
                }
                else
                {
                    min_energy = min_energy + jump_without_pwr;
                }

                Console.WriteLine("Минимальная энергия: " + min_energy);
            }
            





        }

        
    }
}
