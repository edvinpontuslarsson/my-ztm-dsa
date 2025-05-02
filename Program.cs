using System;

namespace MyZtmDsa
{
    class Program
    {
        static void Main(string[] args)
        {
            // int showtime = MyOwnSandbox.Increment(0);
            int[] numbers = {0, 0, 1, 2, 2, 3, 1, 1, 0};
            int mode = MyOwnSandbox.Mode(numbers);

            Console.WriteLine(mode);
        }
    }
}
