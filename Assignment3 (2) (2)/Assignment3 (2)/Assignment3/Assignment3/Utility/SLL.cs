using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class SLL<User> : ILinkedListADT<User>
    {
        // Head of the linked list
        private Node<User> head;
        // Size of the linked list
        private int _size;

        public SLL()
        {
            this.head = null;
            this._size = 0;
        }

        // Method to prepend an item to the beginning of the linked list
        public void AddFirst(User item)
        {
            Node<User> newNode = new Node<User>(item);
            newNode.next = head;
            head = newNode;
            _size++;
        }

        // Method to append an item to the end of the linked list
        public void AddLast(User item)
        {
            Node<User> newNode = new Node<User>(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<User> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            _size++;
        }

        // Method to remove an item at an index in the linked list
        public void Remove(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            if (index == 0)
            {
                RemoveFirst();
            }
            else
            {
                Node<User> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }
                current.next = current.next.next;
                _size--;
            }
        }

        // Method to remove an item from the start of the linked list
        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Linked list is empty");
            }
            head = head.next;
            _size--;
        }

        // Method to remove an item from the end of the linked list
        public void RemoveLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Linked list is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node<User> current = head.next;
                while (current.next.next != null)
                {
                    current = current.next;
                }
                current.next = null;
            }
            _size--;
        }

        // Method to insert an item at a specific index in the linked list
        public void Insert(int index, User item)
        {
            if (index < 0 || index > _size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            if (index == 0)
            {
                AddFirst(item);
            }
            else if (index == _size)
            {
                AddLast(item);
            }
            else
            {
                Node<User> newNode = new Node<User>(item);
                Node<User> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
                _size++;
            }
        }

        // Method to replace an item in the linked list
        public void Replace(int index, User item)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            Node<User> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            current.data = item;
        }

        // Method to get an item at an index in the linked list
        public User GetValue(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            Node<User> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.data;
        }

        // Method to get the index of an item in the linked list
        public int IndexOf(User item)
        {
            Node<User> current = head;
            int index = 0;
            while (current != null)
            {
                if (current.data.Equals(item))
                {
                    return index;
                }
            }
            return -1;
        }

        // Method to check if the linked list has an item
        public bool Contains(User item)
        {
            return IndexOf(item) != -1;
        }

        // Method to clear all items in the linked list
        public void Clear()
        {
            head = null;
            _size = 0;
        }

        public int Count()
        {
            return _size;
        }

        // Method to get the number of items in the linked list using Properties to achieve 
        public int Size => _size;

        public User[] ToArray()
        {
            User[] array = new User[_size];
            Node<User> current = head;
            int i = 0;
            while (current != null)
            {
                array[i++] = current.data;
                current = current.next;
            }
            return array; 
        }
    }
}

