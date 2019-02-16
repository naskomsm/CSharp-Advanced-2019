using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    public class CustomList : IEnumerable<object>
    {
        private int capacity;
        private object[] arr;

        public CustomList()
        {
            this.arr = new object[0];
            this.Count = 0;
        }

        public object[] Arr
        {
            get { return this.GetOnlyRealElements(); }
        }

        // indexer

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public object RemoveAt(int index)
        {
            if(index < 0 || index >= Count)
            {
                throw new InvalidOperationException("Index out of range");
            }
            object obj = this.arr[index];
            this.arr[index] = null;

            // 1 2 3 null 5 6 null null null . . . . . . .

            for (int i = index; i < this.Count - 1; i++)
            {
                this.arr[i] = this.arr[i + 1];
            }
            this.Count--;
            this.arr[Count] = null;
            
            return obj;
        }

        public void Add(object element)
        {
            if (this.Count == this.arr.Length)
            {
                this.Resize();
            }
            this.arr[Count] = element;
            this.Count++;
        }

        private void Resize()
        {
            int sizeArr = this.arr.Length * 2 == 0 ? 4 : this.arr.Length * 2;

            object[] temp = new object[sizeArr];
            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = this.arr[i];
            }
            this.arr = temp;
        }

        private object[] GetOnlyRealElements()
        {
            object[] temp = new object[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = arr[i]; 
            }
            return temp;
        }

        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null)
                {
                    yield return arr[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
          => this.GetEnumerator();
    }
}
