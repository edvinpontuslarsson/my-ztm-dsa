using System;
using System.Collections;

namespace MyZtmDsa
{
    class MyOwnSandbox
    {
        public static int Increment (int n) => n + 1;

        public static int[] Mode (int[] numbers)
        {

            Array.Sort(numbers);

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int maxOccurance = 0;

            foreach (int current in numbers)
            {
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

            List<int> modeList = new List<int>();

            foreach (int key in dictionary.Keys)
            {
                if (dictionary[key] == maxOccurance)
                {
                    modeList.Add(key);
                }
            }

            return modeList.ToArray();
        }
    }
    
}
