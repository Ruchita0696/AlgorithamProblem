using System;

namespace AlgorithamProblem
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 2. Binary Search ");
            Console.WriteLine("Choose - 3. Insertion Sort ");
            Console.WriteLine("Choose - 4. Bubble Sort ");

            Console.Write("\nEnter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    Console.WriteLine("\nEnter the Car Name which you want to search Using Binary Search : ");
                    string cars = Console.ReadLine();
                    BinarySearch search = new BinarySearch();
                    break;

                case 2:
                    Insertionsort insertion = new Insertionsort();
                    insertion.ArrayData();
                    break;

                   
                case 3:
                    BubbleSort bubble = new BubbleSort();
                    bubble.ArrayData();
                    break;
            }
        }
    }
}
