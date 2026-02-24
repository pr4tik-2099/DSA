using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.LINKED_LIST
{
    public class LinkedListTraverse
    {
       public void Traverse()
        {
            Node a = new Node();
            Node b = new Node();
            Node c = new Node();
            Node d = new Node();

            a.Data = 10;
            a.Next = b;
            b.Data = 20;
            b.Next = c;
            c.Data = 30;
            c.Next = d;
            d.Data = 40;

            Node current = a;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next; 
            }
        }
    }
}