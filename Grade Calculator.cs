using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;
            
            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("       GRADE CALCULATOR APPLICATION      ");
                Console.WriteLine("=========================================");
                
                // Call the Grade Calculator
                RunGradeCalculator();
                
                // Ask if user wants to continue
                Console.Write("\nDo you want to calculate another grade? (Y/N): ");
                string response = Console.ReadLine()?.Trim().ToUpper();
                
                if (response != "Y" && response != "YES")
                {
                    continueRunning = false;
                    Console.WriteLine("\nThank you for using the Grade Calculator. Goodbye!");
                }
            }

            if (!Console.IsInputRedirected && !Console.IsOutputRedirected)
            {
                try
                {
                    Console.ReadKey();
                }
                catch (InvalidOperationException)
                {
                    // Ignore when launched in a redirected/non-interactive environment.
                }
            }
        }

        static void RunGradeCalculator()
        {
            Console.WriteLine("\n--- GRADE CALCULATOR ---");
            Console.WriteLine("Enter a numerical grade between 0 and 100.");
            Console.WriteLine("-----------------------------------------");
            
            try
            {
                // Prompt user for input
                Console.Write("Enter grade: ");
                string input = Console.ReadLine();
                
                // Validate input is not empty
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Please enter a value.");
                    return;
                }
                
                // Parse the input to integer
                int grade = int.Parse(input);
                
                // Validate grade range
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                    return;
                }
                
                // Determine letter grade
                string letterGrade = GetLetterGrade(grade);
                
                // Display results
                Console.WriteLine("\n=========================================");
                Console.WriteLine($"Numerical Grade: {grade}");
                Console.WriteLine($"Letter Grade:    {letterGrade}");
                
                // Additional feedback
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(GetGradeFeedback(letterGrade));
                Console.WriteLine("=========================================");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Number is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static string GetGradeFeedback(string letterGrade)
        {
            switch (letterGrade)
            {
                case "A":
                    return "Excellent! Outstanding performance!";
                case "B":
                    return "Good job! Above average performance.";
                case "C":
                    return "Satisfactory performance. Keep improving!";
                case "D":
                    return "Below average. Need more effort.";
                case "F":
                    return "Failing. Please seek help and improve.";
                default:
                    return "";
            }
        }
    }
}