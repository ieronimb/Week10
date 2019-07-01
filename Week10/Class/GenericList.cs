using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.GenericList
{
    /*Problem 1. Generic class
    Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
    clearing the list, finding element by its value and ToString().
    Check all input parameters to avoid accessing elements at invalid positions.

    Problem 2. Auto-grow
    Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

    Problem 3. Min and Max
    Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
    You may need to add a generic constraints for the type T.*/

    public class GenericList<T> where T : IComparable<T>
    {
        //Campuri
        private T[] list;
        private int count = 0;

        // Constructor
        public GenericList(int size)
        {
            if (size >= 0)
            {
                this.list = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Format("Negative values"));
            }
        }
        /*Metode*/
        public T this[int i]
        {
            get
            {
                if (i > list.Length || i < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", i));
                }
                else
                {
                    return this.list[i];
                }
            }
            set
            {
                if (i > list.Length || i < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", i));
                }
                else
                {
                    this.list[i] = value;
                }
            }
        }
        /*Methods for adding element*/
        public void AddElement(T element)
        {
            if (count >= list.Length)
            {
                DoublingList();                
            }
            list[count] = element;
            count++;
        }

        /*Metod to remove element by index*/
        public void RemoveElement(int index)
        {
            try
            {
                if (index <= list.Length || index >= 0)
                {
                    T[] tempArray = new T[list.Length - 1];
                    int tempIndex = 0;

                    for (int i = 0; i < list.Length; i++)
                    {
                        if (i != index)
                        {
                            tempArray[tempIndex] = list[i];
                            tempIndex++;
                        }
                    }

                    list = tempArray;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
        }
        /*Clear the list*/
        public void ClearList()
        {
            list = new T[0];
        }
        /*Override to string*/
        public override string ToString()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(" - {0} - ", list[i]);
            }
            return base.ToString(); 
        }

        /*Find minimal element*/
        public T Min()
        {
            if (list.Length == 0)
            {
                throw new Exception("The list is empty");
            }
            else if (list.Length == 1)
            {
                return list[0];
            }
            else
            {
                T minElement = list[0];
                for (int i = 0; i < list.Length; i++)
                {
                    if (minElement.CompareTo(list[i])>0)
                    {
                        minElement = list[i];
                    }
                }
                return minElement;
            }
        }
        /*Find maximal element*/
        public T Max()
        {
            if (list.Length == 0)
            {
                throw new Exception("The list is empty");
            }
            else if (list.Length == 1)
            {
                return list[0];
            }
            else
            {
                T maxElement = list[0];
                for (int i = 0; i < list.Length; i++)
                {
                    if (maxElement.CompareTo(list[i]) <0)
                    {
                        maxElement = list[i]
;                   }
                }
                return maxElement;
            }
        }

        /*Problem 2. Auto-grow: Doubling the list*/
        private void DoublingList()
        {
            T[] tempList = new T[list.Length * 2];
            Array.Copy(list, tempList, list.Length);
            list = tempList;
        }        
    }
}
