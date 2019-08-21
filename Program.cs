using System;
using System.Collections.Generic;

namespace Niven_series
{
    class Program
    {

        static List<int> serperateDigits(int n)
        {
            List<int> returnedList = new List<int>();

            while(n >= 0)
            {
                if (n < 10)
                {
                    returnedList.Add(n);
                    return returnedList;
                }
                returnedList.Add(n % 10);
                n /= 10;
            }
            return returnedList;

        }
        static void Main(string[] args)
        {
            List<int> digitList = new List<int>();
            List<int> NivenSeries = new List<int>();

            //Set where to start testing numbers
            int testNumber = 1;

            while (NivenSeries.Count < 20)
            {
                int digitsAdded = 0;
                digitList = serperateDigits(testNumber);
                foreach (int n in digitList)
                {
                    digitsAdded += n;
                }
                if(testNumber % digitsAdded == 0)
                {
                    NivenSeries.Add(testNumber);
                }
                testNumber++;
            }
            foreach(int n in NivenSeries)
            {
                Console.WriteLine("{0}\n",n);
            }

        }
    }
}
