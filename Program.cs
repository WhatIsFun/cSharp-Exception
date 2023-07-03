namespace cSharp_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine(a[5]);
            //Console.WriteLine();
        }

        static float divide (float a, float b)
        {
            return a / b;
        }


    }
}