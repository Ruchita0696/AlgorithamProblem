using System;

namespace AlgorithamProblem
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Permutation ");
            Console.WriteLine("Enter - 2. Binary Search ");
            Console.WriteLine("Choose - 3. Insertion Sort ");
            Console.WriteLine("Choose - 4. Bubble Sort ");
            Console.WriteLine("Choose - 5. Merge Sort ");

            Console.Write("\nEnter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    Console.Write("\nEnter String for Permutation : ");
                    string str = Console.ReadLine();
                    int Length = str.Length;
                    Console.WriteLine("Using Recursion Method Permutations are :: ");
                    Permutation.RecursionPermutation(str, 0, Length - 1); // using Recursion Menthod
                    Console.WriteLine("Using Iterative Method Permutations are :: ");
                    Permutation.IterationPermutation(str); // using iterative Menthod
                    break;

                case 2:
                    Console.WriteLine("\nEnter the Car Name which you want to search Using Binary Search : ");
                    string cars = Console.ReadLine();
                    BinarySearch search = new BinarySearch();
                    break;

                case 3:
                    Insertionsort insertion = new Insertionsort();
                    insertion.ArrayData();
                    break;

                   
                case 4:
                    BubbleSort bubble = new BubbleSort();
                    bubble.ArrayData();
                    break;

                case 5:
                    Mergesort merge = new Mergesort();
                    merge.ArrayData();
                    break;

                case 6:
                    Console.Write("Enter 1st Word : ");
                    string str1 = Console.ReadLine();
                    Console.Write("Enter 2nd Word : ");
                    string str2 = Console.ReadLine();
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram(str1, str2);
                    break;

                case 7:
                    Console.Write("Starting number of range: ");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ending number of range : ");
                    int End = Convert.ToInt32(Console.ReadLine());
                    Console.Write("The prime numbers between {0} and {1} are : \n", start, End);
                    PrimeNumber prime = new PrimeNumber();
                    prime.CheckPrimeNumber(start, End);
                    break;
            }
        }
    }
}
