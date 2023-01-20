using Newtonsoft.Json;
using System;

namespace AlgorithamProblem
{
    public class BubbleSort
    {
        public string filePath = @"D:\12.Algorithm Program\AlgorithamProblem\AlgorithamProblem\BinarySearch.json";

        public void ArrayData()
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split(',');
            Console.WriteLine(" Unsorted Array ");
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
            SortUsingBubbleSort(wordsArray);
        }
        public void SortUsingBubbleSort(string[] wordsArray)
        {
            for (int j = 0; j < wordsArray.Length - 1; j++)
            {
                for (int i = j + 1; i < wordsArray.Length; i++)
                {
                    if (wordsArray[j].CompareTo(wordsArray[i]) > 0)
                    {
                        string temp = wordsArray[j];
                        wordsArray[j] = wordsArray[i];
                        wordsArray[i] = temp;
                    }

                }
            }

            Console.WriteLine("\n Sorted Array Using Bubble Sort ");
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }

        }

    }
}
