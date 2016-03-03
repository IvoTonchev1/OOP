﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CustomListT
{
    public class CustomList<T> where T : IComparable<T>
    {
        private T[] elements;
        private const int DefaultCapacity = 8;
        private int currentIndex;

        public CustomList(int initialCapacity = DefaultCapacity)
        {
            this.elements = new T[initialCapacity];
            this.currentIndex = 0;
        }

        public void Add(T elementToAdd)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }
            this.elements[this.currentIndex] = elementToAdd;
            this.currentIndex++;
        }

        private void Resize()
        {
            var newElements = new T[this.elements.Length*2];
            for (int i = 0; i < currentIndex; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }
        public void Remove(T elementToRemove)
        {
            int index = IndexOf(elementToRemove);
            if (index == -1)
            {
                throw new ArgumentException("Specified element was not found.");
            }
            for (int i = index; i < this.currentIndex - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.currentIndex--;
            this.elements[this.currentIndex] = default(T);
            
        }

        public int IndexOf(T elementToFind)
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty.");
            }
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(elementToFind))
                {
                    return i;
                }
            }
            return -1;
        }

        public T Max()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty.");
            }
            T maxElement = this.elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                if (maxElement.CompareTo(this.elements[i]) < 0)
                {
                    maxElement = this.elements[i];
                }
            }
            return maxElement;
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty.");
            }
            T minElemnt = this.elements[0];
            for (int i = 1; i < currentIndex; i++)
            {
                if (minElemnt.CompareTo(this.elements[i]) > 0)
                {
                    minElemnt = this.elements[i];
                }
            }
            return minElemnt;
        }
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index was outside the boundaries of the CustomList.");
                }
                return this.elements[i];
            }
            set
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index was outside the boundaries of the CustomList.");
                }
                this.elements[i] = value;
            }
        }
        public override string ToString()
        {
            return string.Format("[{0}]", string.Join(", ", this.elements.Take(currentIndex)));
        }
    }
}
