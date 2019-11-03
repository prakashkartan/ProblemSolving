using System;
using System.Collections.Generic;
using System.Text;
/*
 * 
 * https://practice.geeksforgeeks.org/problems/find-missing-and-repeating/0
 * */
namespace ConsoleApp12
{
    public class RepeatingMissing
    {

        public void Print(string firstelement)
        {
            int[] array = firstelement.SplitString();
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int dublicateFound = 0;

            foreach (int element in array)
            {
                if (!keyValuePairs.ContainsKey(element))
                {
                    keyValuePairs.Add(element, element);
                }
                else
                {
                    dublicateFound = element;
                    Console.WriteLine(dublicateFound);
                }
            }

            for (int j = dublicateFound - 1; j > 0; j--)
            {
                if (keyValuePairs.ContainsKey(j))
                {
                    Console.WriteLine(j + 1);
                    break;
                }
            }
        }

    }
}
