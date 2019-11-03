using System;
using System.Collections.Generic;
using System.Text;


/*
 * 
 * 
 * https://practice.geeksforgeeks.org/problems/in-first-but-second/0
 * */
namespace ConsoleApp12
{
   public class MissingArrayElement
    {
        public void Print(string firstElement,string secondElement)
        {
            int[] outputarrayA = StringSplit(firstElement);
            int[] outputarrayB = StringSplit(secondElement);

            Dictionary<int, int> keyValuePairsOfB = new Dictionary<int, int>();

            foreach (int element in outputarrayB)
            {
                if (!keyValuePairsOfB.ContainsKey(element))
                {
                    keyValuePairsOfB.Add(element, element);
                }
            }
            Console.WriteLine("Output:");
            foreach (int element in outputarrayA)
            {
                if (!keyValuePairsOfB.ContainsKey(element))
                {
                    Console.WriteLine(element);
                }
            }
        }

        public int[] StringSplit(string input)
        {
            int counter = 1;
            int i = 0;
            foreach (char c in input.Trim())
            {
                if (c == ' ')
                {
                    counter++;
                }

            }
            int[] array = new int[counter];
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    i++;

                }

                else
                {
                    array[i] = Convert.ToInt32(array[i].ToString() + c.ToString());
                }
            }

            return array;


        }
    }
}
