using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string result = string.Empty;
            for (int S = 0; S < original.Length; S++)
            {
                result = result + original[S] + original[S];
            }
            return  result;
        }
    }
}
