namespace cSharp_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 0 };

            try
            {
                Console.WriteLine(a[2] / a[1]);
                Console.WriteLine(a[10] / a[1]);
                Console.WriteLine(a[2] / a[3]);

            }catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Outside of Index!!!");
            }catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Can not Divide by Zero");
            }
            Console.WriteLine("... Program Completed ...");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //Console.WriteLine(a[5]);
            //Console.WriteLine(divide(4,2));
            //Console.WriteLine(divide(2, 2));
            //Console.WriteLine(divide(2, 0));
            //Console.WriteLine(divide(3, 6));
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


    }
}