using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal interface ISort
    {
        public static int[] arr { get; set; }
        public static bool IsAsc { get; set; }
        public void SortAsc(int[] arr);
        public void SortDesc(int[] arr);
        public void SortByParam(bool IsAsc, int[] arr);

    }
}
