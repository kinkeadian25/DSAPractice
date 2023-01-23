using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class RemoveDupLinkedList
    {
        public class LinkedList
        {
            public int value;
            public LinkedList? next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            LinkedList currentNode = linkedList;

            while (currentNode.next != null)
            {
                if (currentNode.value == currentNode.next.value)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }
            return linkedList;
        }
    }
}