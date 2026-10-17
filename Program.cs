using System;


class Program
{
    static void Main()
    {
        int n = 0;

        while (true)
        {
            Console.Write("Введите число студентов (от 1 до 50): ");

            int KS = int.Parse(Console.ReadLine());

            if (KS >= 1 && KS <= 50)
            {
                n = KS;
                break;
            }
            else Console.WriteLine("Ошибка: нужно ввести целое число от 1 до 50.");
        }

        Console.WriteLine("Вы ввели: " + n);

        int[] ball = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.WriteLine("Введите балл студента " + (i+1) + " (от 1 до 100)");
                int B = int.Parse(Console.ReadLine());
                if (B >= 1 && B <= 100)
                {
                    ball[i] = B;
                    break;
                }
                else Console.WriteLine("Ошибка: нужно ввести целое число от 1 до 100");
            }
        }

        int SumB = 0;

        for (int i = 0; i < n; i++)
        {
            SumB = SumB + ball[i];
        }

        double SB = (double)SumB / n;

        Console.WriteLine("Средний балл: " + SB.ToString("F1"));
    }
}