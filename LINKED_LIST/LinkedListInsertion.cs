using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA.LINKED_LIST
{
    public class LinkedListInsertion
    {
        LinkedListTraverse LLt = new LinkedListTraverse();
        
        public void InsertAtBeginning()
        {
            Node newNode = new Node();
            newNode.Data = 5;
            newNode.Next = LLt.a; 
            LLt.head = newNode; // Point the new node to the current head (first node)
            LLt.Traverse(); // Traverse to see the updated list
        }
    }
}