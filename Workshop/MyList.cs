using System;

namespace Workshop1
{
    public class MyList
    {
        private int[] Items { get; set; }
        public int Count { get; set; }

        public MyList()
        {
            this.Items = new int[2];
            this.Count = 0;
        }

        public int this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.Items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.Items[index] = value;
            }
        }

        public void Add(int num)
        {
            if (this.Count == this.Items.Length)
            {
                this.Resize();
            }
            this.Items[Count] = num;
            this.Count++;
        }

        private void Resize()
        {
            int[] newArray = new int[this.Items.Length * 2];
            for (int i = 0; i < this.Items.Length; i++)
            {
                newArray[i] = this.Items[i];
            }
            this.Items = newArray;
        }

        public int RemoveAt(int index)
        {
            // 1) index validation ->argumentOutOfRangeExeption
            // 2) save removed item
            // 3) shift of elements
            // 4) count--
            // 5) shrink of array-> count==length/4->length/2

            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            int removedItem = this.Items[index];
            ShiftToLeft(index);
            this.Count--;
            if (this.Count == this.Items.Length / 4)
            {
                Shrink();
            }
            return removedItem;
        }

        private void ShiftToLeft(int index)
        {
            for (int i = index; i < this.Items.Length; i++)
            {
                this.Items[i] = this.Items[i + 1];
            }
            this.Items[Items.Length - 1] = default;
        }

        private void Shrink()
        {
            int[] newArray = new int[this.Items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.Items[i];
            }
            this.Items = newArray;
        }

        public bool Contains(int num)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Items[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public void InsertAt(int index, int item)
        {
            // index validation
            // resize needed?
            //shift elements
            // add element
            //count++
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (this.Count == this.Items.Length)
            {
                Resize();
            }
            ShiftToRight(index);
            this.Items[index] = item;
            this.Count++;
        }

        private void ShiftToRight(int index)
        {
            for (int i = this.Count; i >= index; i--)
            {
                this.Items[i] = this.Items[i - 1];
            }
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= this.Items.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (secondIndex < 0 || secondIndex >= this.Items.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            int firstNum = this.Items[firstIndex];
            this.Items[firstIndex] = this.Items[secondIndex];
            this.Items[secondIndex] = firstNum;
        }
        public void Reverse()
        {
            int[] newArray = new int[this.Items.Length];
            for (int i = 0; i < this.Count/2; i--)
            {
                Swap(i, this.Count - 1 - i);
            }
            this.Items = newArray;
        }
        public override string ToString()
        {
            return string.Join(' ',this.Items);
        }
        public bool Remove(int num)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if(this.Items[i]==num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}