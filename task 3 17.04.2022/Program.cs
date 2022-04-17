using System;

namespace task_3_17._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded elave edin");
            int number = Convert.ToInt32(Console.ReadLine());
            //int[] numbers;

            if (number<50)
            {
                for (int i = 0; i < number; i++)
                {
                    if (i%3==0)
                    {
                        int numbersSize = (number / 3) + 1;
                        int[] numbers = new int[numbersSize];
                        Console.WriteLine(i);
                    }
                }
            }
            if (number > 50 && number < 100)
            {
                for (int i = 0; i < number; i++)
                {
                    if (i % 5 == 0)
                    {
                        int numbersSize = (number / 5) + 1;
                        int[] numbers = new int[numbersSize];
                        Console.WriteLine(i);
                    }
                }
            }
            if (number > 100)
            {
                for (int i = 0; i < number; i++)
                {
                    if (i % 8 == 0)
                    {
                        int numbersSize = (number / 8) + 1;
                        int[] numbers = new int[numbersSize];
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
