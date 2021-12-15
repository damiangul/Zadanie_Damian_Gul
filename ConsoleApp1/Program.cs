using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] candiesPerChild(int input1, int input2)
        {
            int numberOfCandiesLeft = input1;

            int[] arrCandiesPerChild = new int[input2];

            for(int i=0; i<arrCandiesPerChild.Length; i++)
            {
                arrCandiesPerChild[i] = 0;
            }

            for (int i=1; i<=input2; i++)
            {
                if(numberOfCandiesLeft - i >= 0)
                {
                    arrCandiesPerChild[i - 1] = arrCandiesPerChild[i - 1] + i;
                    numberOfCandiesLeft = numberOfCandiesLeft - i;
                } 
                else if(numberOfCandiesLeft - i < 0 && numberOfCandiesLeft > 0)
                {
                    arrCandiesPerChild[i - 1] = arrCandiesPerChild[i - 1] + numberOfCandiesLeft;
                    numberOfCandiesLeft = numberOfCandiesLeft - i;
                    continue;
                }
            }

            if (numberOfCandiesLeft > 0)
            {
                for(int i=1; i<=input2; i++)
                {
                    if (numberOfCandiesLeft - (input2 + i) >= 0)
                    {
                        arrCandiesPerChild[i - 1] = arrCandiesPerChild[i - 1] + (input2 + i);
                        numberOfCandiesLeft = numberOfCandiesLeft - (input2 + i);
                    } 
                    else if (numberOfCandiesLeft - (input2 + i) < 0 && numberOfCandiesLeft > 0)
                    {
                        arrCandiesPerChild[i - 1] = arrCandiesPerChild[i - 1] + numberOfCandiesLeft;
                        numberOfCandiesLeft = numberOfCandiesLeft - (input2 + i);
                        continue;
                    }
                }
            }

            return arrCandiesPerChild;
        }

        public static void Main(String[] args)
        {
            int numberOfCandies = 10;
            int numberOfChildres = 3;

            int[] arr = new int[numberOfChildres];

            arr = candiesPerChild(numberOfCandies, numberOfChildres);

            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}
