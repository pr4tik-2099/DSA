using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.ARRAY
{
    // Array is a data Structure that can hold a fixed number of values of the same type, stored in contiguous memory locations.
    public class Arrays
    {
        //Inserting an element at the last position of the array 
        public void InsertionAtLast()
        {
            int arrLen = 8;
            int[] arr = new int[arrLen];

            //using this length variable for capacity to incert
            int length = 0;

            for(int i = 0 ; i < arrLen-1 ; i++)
            {
                arr[length] = i+1;
                length++;
            }
             Console.Write(String.Join(", ",arr));

             Console.WriteLine("");

            arr[length] = 8;
            //Console.Write(arr[length]);
             Console.Write(String.Join(", ",arr));
        }

        //Inserting element at the Start of the Array
        public void InsertionAtFirst()
        {
            int arrLen = 8;
            int[] arr = new int[arrLen];

            //using this length variable for capacity
            int length = 0;

            for(int i = 0 ; i < arrLen - 1; i++)
            {
                arr[length] = i+1;
                length++;
                
            }
            Console.Write(String.Join(", ",arr));

            Console.WriteLine("");

            for(int i = arrLen - 2 ; i >= 0 ; i--)
            {
                arr[i+1] = arr[i];
            }

            Console.WriteLine("");

            arr[0] = 8;
            Console.Write(String.Join(", ",arr));
        }
    }
}