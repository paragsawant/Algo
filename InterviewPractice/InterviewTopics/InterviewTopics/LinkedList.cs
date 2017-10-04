using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTopics
{
    public class LinkedList
    {
        public LinkedListNode head;

        public void Add(int data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            LinkedListNode tempNode = head;
            while (tempNode.nextNode != null)
            {
                tempNode = tempNode.nextNode;
            }

            tempNode.nextNode = newNode;
        }

        public void Add(LinkedListNode node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            LinkedListNode currentNode = head;
            while (currentNode.nextNode != null)
            {
                currentNode = currentNode.nextNode;
            }

            currentNode.nextNode = node;
            node.nextNode = null;
        }

        public void Append(LinkedListNode node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            LinkedListNode currentNode = head;
            while (currentNode.nextNode != null)
            {
                currentNode = currentNode.nextNode;
            }

            currentNode.nextNode = node;

        }

        public void DeleteNodeLastNode()
        {

        }

        public void DeleteNode(int value)
        {
            LinkedListNode returnNode = new LinkedListNode(0)
            {
                nextNode = head
            };

            LinkedListNode currentNode = returnNode;
            while (currentNode.nextNode != null)
            {
                if (currentNode.nextNode.data == value)
                {
                    currentNode.nextNode = currentNode.nextNode.nextNode;
                }
                else
                {
                    currentNode.nextNode = currentNode.nextNode;
                }
            }

        }

        public LinkedListNode Reverse(LinkedListNode node)
        {
            LinkedListNode currentNode = node;
            LinkedListNode previousNode = null;
            LinkedListNode nextNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.nextNode;
                currentNode.nextNode = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }
            node = previousNode;
            return node;
        }

        public string PrintLinkedList(LinkedListNode node)
        {
            StringBuilder sb = new StringBuilder();
            LinkedListNode currentNode = node;
            while (currentNode != null)
            {
                sb.Append(currentNode.data);
                currentNode = currentNode.nextNode;
            }

            return sb.ToString();
        }
    }
}
