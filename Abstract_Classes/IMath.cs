using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal interface IMath
    {
        public static int[] arr { get; set; }
        public static int ValueToSearch { get; set; }
        public int Max(int[] arr);
        public int Min(int[] arr);
        public float Avg(int[] arr);
        public bool Search(int ValueToSearch, int[] arr);
    }
}
