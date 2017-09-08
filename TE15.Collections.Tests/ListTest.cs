using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TE15.Collections.Tests
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Empty_List_Should_Return_Count_Zero()
        {
            // Arrange
            var list = new List();
            var expected = 0;

            // Act
            var actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_One_Should_Return_Count_One()
        {
            // Arrange
            List list = new List();
            list.Add(10);
            var expected = 1;
            // Act
            var acctual = list.Count;

            // Assert
            Assert.AreEqual(expected, acctual);
        }

        [TestMethod]
        public void Add_More_Values_Then_Initial_Size_Should_Work()
        {
            // Arrange
            var list = new List();
            var expected = 11;
            // Act
            for (int i = 0; i < expected; i++)
            {
                list.Add(i);
            }
            // Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void Find_Should_Return_Correct_Position()
        {
            // Arrange
            List list = new List();
            list.Add(10);
            list.Add(9);
            list.Add(8);
            var expected = 1;
            // Act
            var actual = list.Find(9);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Find_Not_Existing_Should_Return_Negative_Value()
        {
            // Arrange
            List list = new List();
            list.Add(10);
            list.Add(9);
            list.Add(8);
            var expected = -1;
            // Act
            var actual = list.Find(5);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAt_Should_Return_Correct_Value()
        {
            // Arrange
            List list = new List();
            list.Add(10);
            list.Add(9);
            list.Add(8);
            var expected = 10;
            // Act
            var actual = list.GetAt(0);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetAt_OutOfRange_Should_Throw()
        {
            // Arrange
            List list = new List();
            list.Add(10);
            list.Add(9);
            list.Add(8);
           
            // Act
            var actual = list.GetAt(4); 
        }

        [TestMethod]
        public void RemoveAt_Should_Remove_CorrectValue()
        {
            //Arrange
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var expected_1 = 1;
            var expected_3 = 3;

            // Act
            list.RemoveAt(1);

            // Assert
            Assert.AreEqual(expected_1, list.GetAt(0));
            Assert.AreEqual(expected_3, list.GetAt(1));

        }

        [TestMethod]
        public void RemoveAt_Should_Decrease_Count()
        {
            //Arrange
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var expected = list.Count - 1;
            // Act
            list.RemoveAt(1);

            //Assert
            Assert.AreEqual(expected, list.Count);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_Larger_Position_Then_Current_Capacity_Should_Throw()
        {
            //Arrange
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //Act
            list.RemoveAt(3);
        }
    }
}
