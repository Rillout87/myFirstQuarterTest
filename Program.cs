using System;


namespace myFirstQuarterTest
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] arrayInput = {"hello", "2", "world", ":-)"};
            int symbolsCount = 3;
            string[] resultArray = new string[CountResultArray(arrayInput, symbolsCount)];

        }
    
        static int CountResultArray (string[] arrInput, int symbCount)
        {
            int count = 0;
            for (int i = 0; i < arrInput.Length; i++)
            {
                if (arrInput[i].Length <= symbCount) count++;
            }
            return count;
        }
    }
}
