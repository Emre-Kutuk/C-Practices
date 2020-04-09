using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class ArrayStack : IStack
    {
        int[] list;
        int index = 0;

        public ArrayStack(int max)
        {
            list = new int[max];
        }

        public int Count { get { return index; } }

        public bool IsEmpty { get { if (index == 0) return true;  else  return false;  } }

        public bool Contains(int value)
        {
            foreach(int i in list)
            {
                if (i == value)
                return true;
            }
            return false;
        }

        public int Pop()
        {
            List<int> temp = new List<int>(list);
            int nr = list[index -1];
            temp.RemoveAt(index -1);
            list = temp.ToArray();
            index--;
            return nr;
        }

        public void Push(int value)
        {
            list[index] = value;
            index++;
        }
    }
}
