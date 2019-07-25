using System;

namespace AverageArrayProject {
    class Program { 
        static void Main(string[] args) {
            int[] scores = { 71, 78, 89, 73, 68, 73, 96, 71, 72, 65, 87, 63 };
            int index = 0;
            int sum = 0;
            while (index < 12) {
                sum = sum + scores[index];
                index++;
            }
            int average = 0;
            if (index == 12) {
                average = sum / 12;
            }
            Console.WriteLine($"The Average is {average}%");
        }
    }
}
