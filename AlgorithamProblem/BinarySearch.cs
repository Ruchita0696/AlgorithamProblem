using Newtonsoft.Json;
using System;


namespace AlgorithamProblem
{
    internal class BinarySearch
    {
        public class Binarysearch
        {
            public string filePath = @"D:\12.Algorithm Program\AlgorithamProblem\AlgorithamProblem\BinarySearch.json";

            public void BinarySearchWordCheck(string str)
            {
                string words = File.ReadAllText(filePath);
                string word = JsonConvert.DeserializeObject<string>(words);

                string[] wordsArray = word.Split(',');
                Array.Sort(wordsArray);
                int pos = Array.BinarySearch(wordsArray, str);

                if (pos + 1 >= 0)
                {
                    Console.WriteLine($"{str} found at position " + pos + "\n");
                }
                else
                {
                    Console.WriteLine($"{str} not found\n");
                }

            }
        }
    }
}
