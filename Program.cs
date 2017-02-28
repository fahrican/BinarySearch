using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = {33, 55, 77, 8, 12, 4, 11};
            int[] sortedCopy = (from element in myArr orderby element ascending select element).ToArray();
            Console.WriteLine("The solution: " + binarySearch(33, sortedCopy));
            Console.ReadLine();
            
        }//end of main-method

        public static int binarySearch(int key, int[] nums)
        {
            int ceil = nums.Length;
            int floor = -1;
            Boolean found = false;
            
            while (!found) {

                int distance = ceil - floor;
                int halfWay = distance / 2;
                int idx = floor + halfWay;
                int arrVal = nums[idx];

                if (arrVal == key)
                {
                    found = true;
                    return arrVal;
                }
                else if (arrVal > key)
                {
                    ceil = idx;
                }
                else
                {
                    floor = idx;
                }
            }

            return -1;
        }//end of method
    }
}
