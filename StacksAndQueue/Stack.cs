using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StacksAndQueue
{
    public class Stack
    {
       public LinkedList linkedlist;

        public Stack()
        {
            this.linkedlist = new LinkedList();
        }

        public void push(int data)
        {
            linkedlist.add(data);
        }

        public void print()
        {
            linkedlist.display();
        }
    }
}
