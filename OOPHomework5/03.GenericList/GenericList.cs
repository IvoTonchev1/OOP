using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [Version(0, 1)]
    public class GenericList<T> : IEnumerable where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] array;

        public GenericList(int initialCapacity = DefaultCapacity)
        {
            this.array = new T[initialCapacity];
            this.Count = this.Count = 0;
        }

        // Gets the number of elements that have been added to the GenericList.
        public int Count { get; private set; }

        // Gets the current capacity of the GenericList. If the number of elements exceeds the capacity, the capacity is doubled.
        public int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        // Returns the element at the given index of the GenericList.
        public T this[int index]
        {
            get
            {
                if (index < 0 || this.Count <= index)
                {
                    throw new IndexOutOfRangeException("Index is outside the boundaries of the GenericList.");
                }
                return this.array[index];
            }
        }

        // Finds the minimal value element of the CustomList.
        public T Min()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("The GenericList is empty");
            }

            T minEelement = this.array[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (minEelement.CompareTo(this.array[i]) > 0)
                {
                    minEelement = this.array[i];
                }
            }
            return minEelement;
        }

        // Finds the maximal value element of the CustomList
        public T Max()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("The GenericList is empty");
            }
            T maxEelement = this.array[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (maxEelement.CompareTo(this.array[i]) < 0)
                {
                    maxEelement = this.array[i];
                }
            }
            return maxEelement;
        }

        // Adds the specified element at the end of the list.
        public void Add(T elementToAdd)
        {
            if (this.Count + 1 >= this.array.Length)
            {
                this.ResizeList();
            }
            this.array[this.Count] = elementToAdd;
            this.Count++;
        }

        // Removes the element at the specified index.
        public void RemoveAt(int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new IndexOutOfRangeException("Index is outside the boundaries of the GenericList.");
            }
            T[] newArray = new T[this.array.Length];
            Array.Copy(this.array, 0, newArray, 0, index);
            Array.Copy(this.array, index + 1, newArray, index, this.Count - index - 1);
            this.Count--;
            this.array = newArray;
        }

        // Removes the first occurrence (if any) of the specified element from the GenericList.
        public void Remove(T elementToRemove)
        {
            int index = this.IndexOf(elementToRemove);
            if (index == -1)
            {
                throw new ArgumentException("Specified element was not found.");
            }
            this.RemoveAt(index);
        }

        // Inserts a new element at the specified index.
        public void InsertAt(int index, T newElement)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
            }
            if (this.Count == this.array.Length)
            {
                this.ResizeList();
            }
            T[] newArray = new T[this.Capacity];
            Array.Copy(this.array, 0, newArray, 0, index);
            newArray[index] = newElement;
            this.Count++;
            Array.Copy(this.array, index, newArray, index + 1, this.Count - index - 1);
            this.array = newArray;
        }

        // Searches for the first occurrence of the specified element in the list and returns its index if found, -1 otherwise.
        public int IndexOf(T elementToFind)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            for (int index = 0; index < this.Count; index++)
            {
                if (object.ReferenceEquals(this.array[index], elementToFind))
                {
                    return index;
                }
                if (typeof(T).IsValueType && this.array[index].Equals(elementToFind))
                {
                    return index;
                }
            }
            return -1;
        }

        // Clears the contents of this instance of the GenericList.
        public void Clear()
        {
            this.Count = 0;
            this.array = new T[DefaultCapacity];
        }

        // Searches for the last occurrence of the specified element in the list and returns its index if found, -1 otherwise.
        public int LastIndexOf(T elementToFind)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            for (int index = this.Count - 1; index >= 0; index--)
            {
                if (object.ReferenceEquals(this.array[index], elementToFind))
                {
                    return index;
                }
                if (typeof(T).IsValueType && this.array[index].Equals(elementToFind))
                {
                    return index;
                }
            }
            return -1;
        }

        // Checks whether the GenericList contains the specified element.
        public bool Contains(T elementToCheck)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            bool contains = this.IndexOf(elementToCheck) != -1;
            return contains;
        }

        public override string ToString()
        {
            var resultElements = this.array.Take(this.Count);

            return this.Count > 0 ? string.Join(", ", resultElements) : "list is empty";
        }

        // Displays version information for the GenericList.
        public void Version()
        {
            Type type = typeof(GenericList<T>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (var ver in allAttributes)
            {
                if (ver is VersionAttribute)
                {
                    VersionAttribute temp = ver as VersionAttribute;
                    Console.WriteLine("GenericList Version {0}.{1}", temp.MajorVersion, temp.MinorVersion.ToString("X2"));
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.array.Take(this.Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // Resizes the GenericList.
        private void ResizeList()
        {
            int newArraySize = this.array.Length * 2;
            T[] newArray = new T[newArraySize];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
    }
}
