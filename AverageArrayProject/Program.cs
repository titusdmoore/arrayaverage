using System;

namespace AverageArrayProject {
    class Program { 
        static void Main(string[] args) {

            // Another way to set arrays
            int[] scores = { 71, 78, 89, 73, 68, 73, 96, 71, 72, 65, 87, 63, 55, 78, 99 };
            int index = 0;
            decimal sum = 0m;
            decimal average = 0.0m;
            int total = scores.Length;

            // Begin a loop that runs through each index in Scores
            while (index < total) {
                sum = sum + scores[index];
                index++;
            }

            // When while has indexed run the if statement to find average
            if (index == total) {
                average = sum / total;
                average = Math.Round(average, 2);
            }

            // Print Average Message
            Console.WriteLine($"The Average is {average}%");
        }
    }
}
