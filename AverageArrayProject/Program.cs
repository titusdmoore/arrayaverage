using System;

namespace AverageArrayProject {
    class Program { 
        static void Main(string[] args) {
            int[] scores = { 71, 78, 89, 73, 68, 73, 96, 71, 72, 65, 87, 63 };
            int index = 0;
            int sum = 0;
            decimal average = 0.0m;
            while (index < 12) {
                sum = sum + scores[index];
                index++;
            }
            if (index == 12) {
                average = sum / 12m;
            }
            Console.WriteLine($"The Average is {average}%");
        }
    }
}
