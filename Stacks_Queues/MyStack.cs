using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    public class MyStack<U> : AStack<U>
    {
        U[] StackArray;
        int position;

        public MyStack()
        {
            StackArray = new U[256];
            position = 0;
        }

        public override bool IsEmpty()
        {
            bool empty = false;

            if (position == 0)
            {
                empty = true;
            }
            return empty;
        }

        public override U Pop()
        {
            if (position == 0)
            {
                throw new Exception("you cant pop of an enpty stack");
            }

            position--;
            return StackArray[position];
        }

        public override void Push(U item)
        {
            if (position >= 256)
            {
                throw new Exception("the stack is full");
            }

            StackArray[position] = item;
            position++;
        }

        public override U Top()
        {
            if (position == 0)
            {
                throw new Exception("Cannot read top element of an emtpy Stack");
            }

            return StackArray[position - 1];
        }
    }
}
