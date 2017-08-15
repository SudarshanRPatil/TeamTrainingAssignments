using System;
using System.Collections.Generic;
using System.Diagnostics;
using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppTestProject
{
    [TestClass]
    public class MyClassTest
    {
        [TestMethod]
        public void ReflexiveTest()
        {
            MyClass myClass1 = new MyClass(5, 10);
            Assert.IsTrue(myClass1.Equals(myClass1));
        }

        [TestMethod]
        public void SymmetricTest()
        {
            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 10);
            Assert.IsTrue(myClass2.Equals(myClass1));
        }

        [TestMethod]
        public void TransitiveTest()
        {
            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 10);
            Assert.IsTrue(myClass2.Equals(myClass1));
            MyClass myClass3 = new MyClass(5, 10);
            Assert.IsTrue(myClass2.Equals(myClass3));
            Assert.IsTrue(myClass1.Equals(myClass3));
        }

        [TestMethod]
        public void AddTest()
        {
            Dictionary<MyClass, string> myDictionary = new Dictionary<MyClass, string>();

            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 15);

            myDictionary.Add(myClass1,"One");
            myDictionary.Add(myClass2, "Two");

            Assert.IsNotNull(myDictionary);
            Assert.AreEqual("One", myDictionary[myClass1]);
            Assert.AreEqual("Two", myDictionary[myClass2]);

            foreach (KeyValuePair<MyClass, string> kvp in myDictionary)
            {
                Debug.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

        [TestMethod]
        public void UpdateTest()
        {
            Dictionary<MyClass, string> myDictionary = new Dictionary<MyClass, string>();

            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 15);

            myDictionary.Add(myClass1, "One");
            myDictionary.Add(myClass2, "Two");

            Assert.IsNotNull(myDictionary);
            Assert.AreEqual("One", myDictionary[myClass1]);
            Assert.AreEqual("Two", myDictionary[myClass2]);

            foreach (KeyValuePair<MyClass, string> kvp in myDictionary)
            {
                Debug.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            myDictionary[myClass2] = "Three";
            Assert.AreEqual("Three", myDictionary[myClass2]);

            Debug.WriteLine("Update value by key : Key = {0}, Value = {1}", myClass2, myDictionary[myClass2]);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Dictionary<MyClass, string> myDictionary = new Dictionary<MyClass, string>();

            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 15);

            myDictionary.Add(myClass1, "One");
            myDictionary.Add(myClass2, "Two");

            Assert.IsNotNull(myDictionary);
            Assert.AreEqual("One", myDictionary[myClass1]);
            Assert.AreEqual("Two", myDictionary[myClass2]);

            foreach (KeyValuePair<MyClass, string> kvp in myDictionary)
            {
                Debug.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Debug.WriteLine("Delete value by using key");

            myDictionary.Remove(myClass2);

            foreach (KeyValuePair<MyClass, string> kvp in myDictionary)
            {
                Debug.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Assert.IsFalse(myDictionary.ContainsKey(myClass2));
        }
    }
}
