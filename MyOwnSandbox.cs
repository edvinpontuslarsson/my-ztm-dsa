using System;
using System.Collections;

namespace MyZtmDsa
{
    class MyOwnSandbox
    {
        public static int Increment (int n) => n + 1;

        public static int Mode (int[] numbers)
        {
            // int[] numbers = {0, 0, 1, 2, 2, 3, 1, 1, 0};

            Array.Sort(numbers);

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int maxOccurance = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                if (dictionary.ContainsKey(current))
                {
                    dictionary[current] = dictionary[current] + 1;
                } 
                else 
                {
                    dictionary[current] = 1;
                }

                if (dictionary[current] > maxOccurance) maxOccurance = dictionary[current];
            }

            return maxOccurance;
        }
    }
    
}
