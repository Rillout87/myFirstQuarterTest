using System;


namespace myFirstQuarterTest
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] arrayInput = {"hello", "2", "world", ":-)"};
            int symbolsCount = 3;

        }
    
        static int CountResultArray (int[] arrInput, int symbCount)
        {
            int count = 0;
            for (int i = 0; i < arrInput.Length; i++)
            {
                if (arrInput[i] <= symbCount) count++;
            }
            return count;
        }
    }
}
