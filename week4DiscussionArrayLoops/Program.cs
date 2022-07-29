namespace ArrayWithLoopsExample
{

    internal static class Program
    {

        static void Main()
        {
            int[] arrayOfInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] arrayOfStrings = { "CEIS101", "CEIS106", "CEIS110", "CEIS114", "CEIS299", "CEIS236", "CEIS150", "CEIS209" };
            double[] arrayOfDoubles = { 23.1823, 3498.123871, 832.12371, 73982.19873471, 1731.23, 27182131123.1231238948 };

            foreach (int i in arrayOfInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to continue to next loop...");
            Console.ReadKey();
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine(arrayOfStrings[i]);
            }
            Console.WriteLine("Press any key to continue to next loop...");
            Console.ReadKey();

            bool u = true;
            int x = 0;
            while (u == true)
            {
                Console.WriteLine(arrayOfDoubles[x]);
                x++;
                if (x == arrayOfDoubles.Length)
                {
                    u = false;
                }
            }

        }

    }

}