using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = { 5, 8, 2, 6, 7, 3, 4 };

                Console.WriteLine("Original Array:");
                PrintArray(randomArray);
                BubbleSort(randomArray);

                Console.WriteLine("\nSorted Array (Descending Order):");
                PrintArray(randomArray);

                bool isSorted = IsSorted(randomArray);
                Console.WriteLine("\nIs the array sorted correctly? " + isSorted);

            // Perform Binary Search
               Console.WriteLine("\nEnter number to search:");
                int searchValue = int.Parse(Console.ReadLine());
                int index = BinarySearch(randomArray, searchValue);

                if (index != -1)
                    Console.WriteLine($"\n{searchValue} found at index {index}.");
                else
                    Console.WriteLine($"\n{searchValue} not found in the array.");
            Console.ReadKey();
            }
        
            static void BubbleSort(int[] array)
            {
                int n = array.Length;
                for (int i=0; i<n-1; i++)
                {
                    for (int j=0; j<n-1- i; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            static bool IsSorted(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                        return false;
                }
                return true;
            }

            static int BinarySearch(int[] array, int searchValue)
            {
                int left = 0;
                int right = array.Length-1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                if (array[mid] == searchValue)
                {
                    return mid;
                }
                
                if (array[mid] > searchValue)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
                }
                return -1;
            }

           static void PrintArray(int[] array)
            {
                foreach (var element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }

