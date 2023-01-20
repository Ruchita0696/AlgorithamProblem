using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
                string word = JsonConvert.SerializeObject(words);

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
