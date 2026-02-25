using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.LINKED_LIST
{
    public class LinkedListInsertion
    {
        LinkedListTraverse llt = new LinkedListTraverse();
        
        public void InsertAtBeginning()
        {
            Node newNode = new Node();
            newNode.Data = 5;
            newNode.Next = llt.a; 
            llt.head = newNode; // Point the new node to the current head (first node)
            llt.Traverse(); // Traverse to see the updated list
        }
    }
}