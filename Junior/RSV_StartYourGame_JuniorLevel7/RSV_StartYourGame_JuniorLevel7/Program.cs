using System;

namespace RSV_StartYourGame_JuniorLevel7
{
    class MainClass
    {

        static int[] results = { 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1 };
        static int[] task_ball;
        static int final_result;
        static int counter = 0;
        static int ball = 5;

        public static void Main(string[] args)
        {
            for (int i = 0; i < results.Length; i++)
            {
                int result = results[i];
                if (result == 1)
                {
                    int j = i;
                    int successfull_tasks = 0;
                    while (j != 0)
                    {
                        //Console.WriteLine(j);
                        j--;
                        if (results[j] == 0)
                        {
                            break;
                        }
                        else
                        {
                            successfull_tasks++;
                        }

                    }
                    
                    //Console.WriteLine(successfull_tasks);
                    final_result = final_result + ball + successfull_tasks;
                    successfull_tasks = 0;
                }
            }
            Console.Write(final_result);
        }
    }
}
