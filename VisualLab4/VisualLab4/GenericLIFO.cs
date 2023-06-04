using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace VisualLab4
{
    class GenericLIFO<T> : IEnumerable<T>
    {
        private IList<T> stack;
        private int size;
        
        public GenericLIFO()
        {
            stack = new List<T>();
            size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Push(T data)
        {
            stack.Insert(0, data);
            size++;
        }

        public T Peek()
        {
            if (stack.Count() == 0)
            {
                throw new Exception("Стек пуст");
            }
            return stack.ElementAt(0);
        }

        public T Pop()
        {
            if (stack.Count() == 0)
            {
                throw new Exception("Стек пуст");
            }
            T item = stack.ElementAt(0);
            stack.RemoveAt(0);
            size--;
            return item;
        }

        public int Size
        {
            get
            {
                return size;
            }
        }
    }
}
