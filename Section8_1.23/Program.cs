using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_1._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }
        public static void runApp()
        {
            string[] students = { "Bob", "Alice", "David", "Grace", "Jack", "Henry", "Frank", "Ivy", "Charlie", "Ella" };

            Console.WriteLine("Unsorted Students:");
            DisplayStudents(students);

            InsertionSort(students);

            Console.WriteLine("\nSorted Students:");
            DisplayStudents(students);
        }

        public static void InsertionSort(string[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                string key = arr[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(arr[j], key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        public static void DisplayStudents(string[] arr)
        {
            foreach (string student in arr)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine();
        }

    }
}
