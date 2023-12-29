using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal class MyArray:IOutput, IMath, ISort
    {
        public static int number { get; set; }
        public static int[] arr { get; set; }
        public static int ValueToSearch { get; set; }
        public static bool IsAsc { get; set; }

        public void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine(" ");
        }
        public void Show(string message, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine($"{message}");
        }
        public int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];

                }
            }
            return min;
        }
        public int Max(int[] arr)
        {
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return max;
        }
        public float Avg(int[] arr)
        {
            float sum = 0;
            float avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            return avg;
        }
        public bool Search(int ValueToSearch, int[] arr)
        {
            bool bl = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ValueToSearch)
                {
                    bl = true;
                }
            }
            return bl;
        }
        public void SortAsc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int z = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = z;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("\n");

        }
        public void SortDesc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int z = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = z;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("\n");
        }
        public void SortByParam(bool IsAsc, int[] arr)
        {
            Random random = new Random();
            var randomBool = random.Next(0, 1);
            if (randomBool == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            switch (randomBool)
            {
                case 0:
                    SortAsc(arr);
                    break;
                default:
                    SortDesc(arr);
                    break;
            }
        }
    }
}

