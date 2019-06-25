using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    public abstract class AStack<T>
    {
        public abstract bool IsEmpty();

        public abstract void Push(T item);

        public abstract T Pop();

        public abstract T Top();
    }
}
