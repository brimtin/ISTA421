using System.Collections.Generic;
using System.Linq;


namespace StackProject
{
    class Stack<StackValue>
    {
        private List<StackValue> list = new List<StackValue>();

        public IEnumerable<StackValue> Data => Enumerable.Reverse(list);

        public int Count { get => list.Count; }

        public StackValue this[int offset]
        {
            get => list[(list.Count - 1) - offset];
        }

        public void Push(StackValue i)
        {
            list.Add(i);
        }

        public StackValue Pop()
        {
            var lastIndex = list.Count - 1;
            var tmp = list[lastIndex];

            list.RemoveAt(lastIndex);

            return tmp;
        }

        public StackValue Peek() => list[list.Count - 1];
    }
}
