using System;

namespace halmaz
{
    public class Set
    {
        private double[] items;
        private int count;
        private int capacity;


        public Set() { }
        public Set(int initialCapacity = 100)
        {
            this.capacity = initialCapacity;
            this.items = new double[capacity];
            this.count = 0;
        }

  
        public void Add(double elem)
        {
          
            if (Contains(elem))
            {
                Console.WriteLine("Az elem már létezik a halmazban!");
                return;
            }

            if (count == capacity)
            {
                Console.WriteLine("A halmaz megtelt!");
                return;
            }

            items[count] = elem;
            count++;
        }

        public void Remove(double elem)
        {
            int index = FindIndex(elem);

            if (index == -1)
            {
                Console.WriteLine("Az elem nem található a halmazban!");
                return;
            }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
        }

        public bool Contains(double elem)
        {
            return FindIndex(elem) != -1;
        }


        private int FindIndex(double elem)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == elem)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Length()
        {
            return count;
        }

        public int GetSize()
        {
            return capacity;
        }
    }
}
