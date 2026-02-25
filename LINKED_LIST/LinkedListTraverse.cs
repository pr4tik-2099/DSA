using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.LINKED_LIST
{
    public class LinkedListTraverse
    {
            public Node a = new Node();
            public Node b = new Node();
            public Node c = new Node();
            public Node d = new Node();

             public Node? head;
       public void Traverse()
        {
            

            a.Data = 10;
            a.Next = b;
            b.Data = 20;
            b.Next = c;
            c.Data = 30;
            c.Next = d;
            d.Data = 40;

            //head = a; // Set head to the first node
            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next!; 
            }
        }
    }
}