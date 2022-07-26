using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueue
{
    public class Queue
    {
        public LinkedList linkedlist;

        public Queue()
        {
            this.linkedlist = new LinkedList();
        }
        public void Enqueue(int data)
        {
          linkedlist.Append(data);
        }

        public void print()
        {
            linkedlist.display();
        }

    }
}
