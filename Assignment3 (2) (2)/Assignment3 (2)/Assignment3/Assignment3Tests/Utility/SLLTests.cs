using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility.Tests
{
    [TestClass()]
    public class SLLTests
    {
        [TestMethod()]
        public void Clear_RemovesAllItemsFromList()
        {
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.Clear();
            Assert.AreEqual(0, list.Size);
            Assert.IsFalse(list.Contains(1));
            Assert.IsFalse(list.Contains(2));
            Assert.IsFalse(list.Contains(3));
        }

        [TestMethod()]
        public void AddFirst_AddsItemToBeginningOfList()
        {
            SLL<int> list = new SLL<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            Assert.AreEqual(3, list.GetValue(0));
            Assert.AreEqual(2, list.GetValue(1));
            Assert.AreEqual(1, list.GetValue(2));
        }
        [TestMethod()]
        public void AddLast_AddsItemToEndOfList()
        {
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            Assert.AreEqual(1, list.GetValue(0));
            Assert.AreEqual(2, list.GetValue(1));
            Assert.AreEqual(3, list.GetValue(2));
        }
      
        [TestMethod()]
        public void RemoveFirst_RemovesFirstItem()
        {
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.RemoveFirst();
            Assert.AreEqual(2, list.GetValue(0));
            Assert.AreEqual(3, list.GetValue(1));
        }
        [TestMethod()]
        public void RemoveLast_RemovesLastItem()
        {
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.RemoveLast();
            Assert.AreEqual(1, list.GetValue(0));
            Assert.AreEqual(2, list.GetValue(1));
        }
        [TestMethod()]
        public void Insert_InsertsItemAtSpecifiedIndex()
        {
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.Insert(1, 3);
            Assert.AreEqual(1, list.GetValue(0));
            Assert.AreEqual(3, list.GetValue(1));
            Assert.AreEqual(2, list.GetValue(2));
        }
        [TestMethod()]
        public void Replace_ReplacesItemAtIndex()
        {
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.Replace(1, 3);
            Assert.AreEqual(1, list.GetValue(0));
            Assert.AreEqual(3, list.GetValue(1));
        }
        [TestMethod()]
        public void GetValue_GetsItemAtIndex()
        {
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            Assert.AreEqual(2, list.GetValue(1));
        }
        [TestMethod()]
        public void Clear_List()
        {
            // Arrange
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            // Act
            list.Clear(); // Clear the list
            // Assert
           
        
        }
        [TestMethod()]
        public void IndexOf_Returns()
        {
            // Arrange
            SLL<int> list = new SLL<int>();
            list.AddLast(1);
            list.AddLast(2);          
            int index = list.IndexOf(1);

            // Assert
            Assert.AreEqual(0, index);
        }








    }
}