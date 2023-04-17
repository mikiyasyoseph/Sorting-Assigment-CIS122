/*Written by
     Mikiyas Yoseph
     Niftalem Kassa
     Hermon Meteferia
*/
using System;
using System.Collections.Generic;


namespace Sorting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                //input list of integers
                List<int> aListOfIntegers = new List<int> { 5, 3, 1, 4, 2 };
                //Context in strategy mehthod(sorter)
                Sorter aSorter1 = new Sorter();
                //asking user what sort they want to use
                Console.WriteLine("\t Pick from" +
                "\n\t1.Bubble Sort" +
                "\n\t2.Selection Sort" +
                "\n\t3.Insertion Sort\n");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    //setting the sort strategy and using it's sort method
                    aSorter1.SortStrategy = new BubbleSort();
                    string inputList = string.Join(" ", aListOfIntegers);
                    string output = string.Join(" ", aSorter1.Sort(aListOfIntegers));
                    Console.WriteLine("Input list: " + inputList);//printing input list
                    Console.WriteLine("Bubble Sort: " + output + "\n");//printing output list
                }
                else if (input == "2")
                {
                    aSorter1.SortStrategy = new SelectionSort();
                    string inputList = string.Join(" ", aListOfIntegers);
                    string outputList = string.Join(" ", aSorter1.Sort(aListOfIntegers));
                    Console.WriteLine("Input list: " + inputList);
                    Console.WriteLine("Selection Sort: " + outputList);
                }
                else if (input == "3")
                {
                    aSorter1.SortStrategy = new InsertionSort();
                    string inputList = string.Join(" ", aListOfIntegers);
                    string output = string.Join(" ", aSorter1.Sort(aListOfIntegers));
                    Console.WriteLine("Input list: " + inputList);
                    Console.WriteLine("Insertion Sort: " + output);
                }
                else
                {
                    Console.WriteLine("incorrect choice try again");
                    continue;
                }
            } 
        }
    }
 }
