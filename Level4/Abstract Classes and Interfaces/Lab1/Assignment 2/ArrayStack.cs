using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class ArrayStack : IStack
    {
        private int[] list;

        public ArrayStack(int max)
        {
            list = new int[max];
            Count = 0;
        }

        public int Count { get; private set;}

        public bool IsEmpty { get { return (Count == 0); } }

        public bool Contains(int value)
        {
            if (list.Contains(value))
                return true;
            else
                return false;
        }

        public int Pop()
        {
            //If empty it throws an exception
            if (!IsEmpty)
            {
                Count--;
                return list[Count];
            }
            else
                throw new Exception("Error : The stack is empty.");
        }

        public void Push(int value)
        {
            //If stack is full it throws an exception
            if (Count < list.Length)
            {
                list[Count] = value;
                Count++;
            }
            else
                throw new Exception("Error : The stack is completely filled.");
        }
    }
}
