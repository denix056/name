using System;


class Program
{
    static void Main()
    {
        int Numberofstudents = 0;

        while (true)
        {
            Console.Write("Введите число студентов (от 1 до 50): ");

            int KS = int.Parse(Console.ReadLine());

            if (KS >= 1 && KS <= 50)
            {
                Numberofstudents = KS;
                break;
            }
            else Console.WriteLine("Ошибка: нужно ввести целое число (от 1 до 50)");
        }


        int[] ball = new int[Numberofstudents];
        for (int i = 0; i < Numberofstudents; i++)
        {
            while (true)
            {
                Console.WriteLine("Введите балл студента " + (i+1) + " (от 0 до 100): ");
                int BallS = int.Parse(Console.ReadLine());
                if (BallS >= 0 && BallS <= 100)
                {
                    ball[i] = BallS;
                    break;
                }
                else Console.WriteLine("Ошибка: нужно ввести целое число от (0 до 100)");
            }
        }

        int SumB = 0;

        for (int i = 0; i < Numberofstudents; i++)
        {
            SumB = SumB + ball[i];
        }

        double SB = (double)SumB / Numberofstudents;

        Console.WriteLine("Средний балл: " + SB.ToString("F1"));
    }
}