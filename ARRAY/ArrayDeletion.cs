using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.ARRAY
{
    public class ArrayDeletion
    {
        public void DeletionAtLast()
        {
            int arrLen = 8;
            int[] arr = new int[arrLen];

            int length = 0;
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = i + 1;
                length++;
            }
            Console.WriteLine(String.Join(", ", arr));
            length--;

            for(int i = 0 ; i < length ; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
    }
}