using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    public abstract class AQueue<T>
    {
        public abstract int Size();

        public abstract T Front();

        public abstract void Enqueue(T item);

        public abstract T Dequeue();

        public abstract void Clear();
    }
}
