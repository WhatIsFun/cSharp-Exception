using System.ComponentModel;
using System;
using System.IO;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace cSharp_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Example 
            //int[] a = { 1, 2, 3, 0 };

            //try
            //{
            //    Console.WriteLine(a[2] / a[1]);
            //    Console.WriteLine(a[10] / a[1]);
            //    Console.WriteLine(a[2] / a[3]);

            //}catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error: Outside of Index!!!");
            //}catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error: Can not Divide by Zero");
            //}
            //Console.WriteLine("... Program Completed ...");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //Console.WriteLine(a[5]);
            //Console.WriteLine(divide(4,2));
            //Console.WriteLine(divide(2, 2));
            //Console.WriteLine(divide(2, 0));
            //Console.WriteLine(divide(3, 6));

            //Task 1:
            //Console.WriteLine("&& & Task 1 & &&");
            //Console.WriteLine("Enter first number>>> ");
            //int fNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number>>> ");
            //int sNumber = Convert.ToInt32(Console.ReadLine());
            //Divide(fNumber, sNumber);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine();
            ////Task 2:
            //Console.WriteLine("&& & Task 2 & &&");
            //Console.WriteLine("Enter your age >>> ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //AgeChecker(age);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine();
            ////Task 3:
            //Console.WriteLine("&& & Task 3 & &&");
            //Console.Write("Enter your file path: ");
            //string filePath = Console.ReadLine();
            //FilePath(filePath);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine();
            ////Task 4:
            //Console.WriteLine("&& & Task 4 & &&");
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //NumericValues(input);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine();
            //Task 5:
            Console.WriteLine("&& & Task 5 & &&");
            //Console.Write("Enter a number between 1 and 100: ");
            //string guessNumber = Console.ReadLine();
            GuessingNumber();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
        }

        //static float divide (int a, int b)
        //{
        //    try
        //    { // Try block identifies a block of code for which particular exceptions is activated. It is followed by one or more catch blocks.
        //        return a / b;
        //    }catch (DivideByZeroException e)
        //    { // Exception handler at the place in a program where you want to handle the problem.
        //        return 0;
        //    }


        //}

        // Task 1: Write a program that asks the user to enter two numbers and divides the first number by the second number.
        // Handle any potential exceptions that may occur, such as divide-by-zero or invalid input.
        static void Divide(int fNumber, int sNumber)
        {
            try
            {
                Console.WriteLine(fNumber / sNumber);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cant Divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("!! Invalid Input !!");
            }
        }
        // Task 2: Create a program that prompts the user to enter their age.
        // Use exception handling to handle cases where the user enters an invalid age, such as a negative number or non-numeric input.
        static void AgeChecker(int age)
        {
            try
            {
                if (age > 0)
                {
                    Console.WriteLine("Your age is " + age);
                }
                else
                {
                    Console.WriteLine("Please enter a positive number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        // Task 3: Write a program that reads a file path from the user and attempts to open the file.
        // Handle any potential exceptions that may occur, such as a file not found or access denied.
        static void FilePath(string filePath)
        {
            try
            {
                using (StreamReader sR = File.OpenText(filePath))
                {
                    string s = "";
                    while ((s = sR.ReadLine()) != null)
                    {
                        Console.WriteLine(s); // To display file contents
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The specified file was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access to the specified file was denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while opening the file: " + ex.Message);
            }
        }
        // Task 4: Create a program that asks the user to enter a series of numeric values.
        // Keep reading values until the user enters a non-numeric input.
        // Handle any exceptions that may occur during the input process.
        static void NumericValues(string input)
        {
            try
            {
                int number = int.Parse(input);
                Console.WriteLine("You enterd: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        // Task 5: Write a program that generates a random number between 1 and 100.
        // Ask the user to guess the number and handle any exceptions that may occur
        // if the user enters an invalid input or if the guessed number is out of range.
        static void GuessingNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int count = 0;
            while (true)
            {
                Console.Write("Guess a number between 1 and 100: ");
                string guessNumber = Console.ReadLine();

                try
                {
                    int guess = int.Parse(guessNumber);

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                        ++count;
                    }
                    else if (guess == randomNumber)
                    {
                        ++count;
                        Console.WriteLine("Congratulations! You guessed the number"+ randomNumber + " After " + count + "tries");
                        break;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("higher. Try again.");
                        ++count;
                    }
                    else
                    {
                        Console.WriteLine("lower. Try again.");
                        ++count;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    ++count;
                }
            }
        }
    }
}