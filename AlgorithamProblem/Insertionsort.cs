using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProblem
{
    public class Insertionsort
    {
        public string filepath = @"D:\12.Algorithm Program\AlgorithamProblem\AlgorithamProblem\BinarySearch.json";
        public void ArrayData()
        {
            string words = File.ReadAllText(filepath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split('.');

            Console.WriteLine("Unsorted Array");
            foreach(string car in wordsArray)
            {
                Console.WriteLine(car);
            }
            SortUsingInsertSort(wordsArray);
        }
        public void SortUsingInsertSort(IComparable[] wordsArray)
        {
            for (int i = 0; i < wordsArray.Length; i++)
            {
                IComparable key = wordsArray[i];
                int j = i - 1;

                while ((j >= 0) && (wordsArray[j].CompareTo(key)> 0))
                {
                    j--;


                }
                wordsArray[j+1] = key;
            }
            Console.WriteLine("\n Sorted array Using Insertion sort");
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
        }
    }
}
