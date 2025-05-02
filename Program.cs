using System;

namespace MyZtmDsa
{
    class Program
    {
        static void Main(string[] args)
        {
            // int showtime = MyOwnSandbox.Increment(0);
            int[] numbers = {0, 0, 1, 2, 13, 2, 13, 13, 3, 1, 1, 0};
            int[] mode = MyOwnSandbox.Mode(numbers);

            Console.WriteLine(string.Join(", ", mode));
        }
    }
}
