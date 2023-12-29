using System;

namespace Abstract_Classes
{
    internal class Program
    {
        public static int number;
        public static int[] arr;
        public static bool IsAsc;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements in the array: ");
            var IsNumber = int.TryParse(Console.ReadLine(), out int number);
            if (IsNumber == false)
            {
                throw new Exception("Sorry, enter the number!");
            }
            arr = new int[number];
            Console.WriteLine(arr.Length);
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            MyArray array = new MyArray();
            array.Show(arr);
            array.Show("It`s the message!", arr);
            Console.WriteLine(array.Max(arr));
            Console.WriteLine(array.Min(arr));
            Console.WriteLine(array.Avg(arr));
            Console.WriteLine("\n");
            Console.WriteLine("Enter the value to search: ");
            bool IsInt = int.TryParse(Console.ReadLine(), out int ValueToSearch);
            if (IsInt == false)
            {
                throw new Exception("Sorry, enter the number!");
            }
            Console.WriteLine(array.Search(ValueToSearch, arr));
            Console.WriteLine("\n");
            array.SortAsc(arr);
            array.SortDesc(arr);
            array.SortByParam(IsAsc, arr);
        }
    }
}
