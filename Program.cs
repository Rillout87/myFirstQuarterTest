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

            FillResultArray(arrayInput, resultArray, 3);
            
            Console.WriteLine(String.Join(", ", resultArray));

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

        static void FillResultArray (string[] arrayInput, string[] resultArray, int symbolsCount)
        {
            int len = arrayInput.Length;
            int index = 0;
            int count = 0;

            while (index < len)
            {
                if (arrayInput[index].Length <= symbolsCount)
                {
                    resultArray[count] = arrayInput[index];
                    count += 1;
                }

                index += 1;
            
            }
        }
    
    }
}
