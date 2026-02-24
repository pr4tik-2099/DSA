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

            a.Data = 10;
            a.Next = b;
            b.Data = 20;
            b.Next = c;
            c.Data = 30;
            
        }
    }
}