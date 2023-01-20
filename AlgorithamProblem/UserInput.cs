using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProblem
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 2. Binary Search ");
            Console.WriteLine("Choose - 3. Insertion Sort ");

            Console.Write("\nEnter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 0:
                    Console.WriteLine("\nEnter the Car Name which you want to search Using Binary Search : ");
                    string cars = Console.ReadLine();
                    BinarySearch search = new BinarySearch();
                    break;

                case 1:
                    Insertionsort insertion = new Insertionsort();
                    insertion.ArrayData();
                    break;
            }
        }
    }
}
