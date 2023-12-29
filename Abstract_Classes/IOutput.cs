using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal interface IOutput
    {
        public static int number { get; set; }
        public static int[] arr { get; set; }


        public void Show(int[] arr);
        public void Show(string message, int[] arr);
    }
}
