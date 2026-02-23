using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.ARRAY
{
    public class ArrayDeletion
    {
        //Deleting an element at the last position of the array
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

        //Deleting an element at the first position of the array
        public void DeleteionAtFirst()
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

            for(int i = 1 ; i < length ; i++)
            {
                arr[i-1]  = arr[i];
            }
            length--;
            for(int i = 0 ; i < length ; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            
        }
    }
}