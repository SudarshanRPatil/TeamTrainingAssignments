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
            Dictionary<string, MyClass> myDictionary = new Dictionary<string, MyClass>();

            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 15);

            myDictionary.Add("One", myClass1);
            myDictionary.Add("Two", myClass2);

            Assert.IsNotNull(myDictionary);

            foreach (KeyValuePair<string, MyClass> kvp in myDictionary)
            {
                Debug.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

        [TestMethod]
        public void UpdateTest()
        {
            Dictionary<string, MyClass> myDictionary = new Dictionary<string, MyClass>();

            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 15);

            myDictionary.Add("One", myClass1);
            myDictionary.Add("Two", myClass2);

            Assert.IsNotNull(myDictionary);

            foreach (KeyValuePair<string, MyClass> kvp in myDictionary)
            {
                Debug.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            MyClass myClass3 = new MyClass(10, 15);
            myDictionary["Two"] = myClass3;

            Console.WriteLine("Update value by key : Key = {0}, Value = {1}", "Two", myDictionary["Two"]);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Dictionary<string, MyClass> myDictionary = new Dictionary<string, MyClass>();

            MyClass myClass1 = new MyClass(5, 10);
            MyClass myClass2 = new MyClass(5, 15);

            myDictionary.Add("One", myClass1);
            myDictionary.Add("Two", myClass2);

            Assert.IsNotNull(myDictionary);

            foreach (KeyValuePair<string, MyClass> kvp in myDictionary)
            {
                Debug.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("Delete value by using key");

            myDictionary.Remove("Two");

            foreach (KeyValuePair<string, MyClass> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
