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
            Console.WriteLine("&& & Task 1 & &&");
            Console.WriteLine("Enter first number>>> ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number>>> ");
            int sNumber = Convert.ToInt32(Console.ReadLine());
            divide(fNumber, sNumber);
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
        static void divide(int fNumber, int sNumber)
        {
            try
            {
                Console.WriteLine (fNumber / sNumber);
            }catch (DivideByZeroException e)
            {
                Console.WriteLine("Cant Divide by zero");
            }catch (Exception e)
            {
                Console.WriteLine("!! Invalid Input !!");
            }
        }
        // Task 2: Create a program that prompts the user to enter their age.
        // Use exception handling to handle cases where the user enters an invalid age, such as a negative number or non-numeric input.
    }
}