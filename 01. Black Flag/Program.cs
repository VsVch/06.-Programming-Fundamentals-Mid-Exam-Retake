using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlumber = int.Parse(Console.ReadLine());
            double expectedPlumber = double.Parse(Console.ReadLine());

            double totalPlumber = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlumber += dailyPlumber;

                if (i % 3 == 0)
                {
                    totalPlumber += dailyPlumber * 0.5;
                }
                if (i % 5 == 0)
                {
                    totalPlumber -= totalPlumber * 0.3;
                }

            }
            if (totalPlumber >= expectedPlumber)
            {
                Console.WriteLine($"Ahoy! {totalPlumber:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(totalPlumber / expectedPlumber * 100):f2}% of the plunder.");
            }
        }
    }
}
