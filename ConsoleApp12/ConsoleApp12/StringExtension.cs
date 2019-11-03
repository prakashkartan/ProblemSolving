using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public static class StringExtension
    {
        public static int[] SplitString(this string input)
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
