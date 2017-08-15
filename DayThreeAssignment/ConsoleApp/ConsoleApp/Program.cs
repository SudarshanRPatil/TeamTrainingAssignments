using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1.Override the Object's ToString() method to show some info about your class.

            MyClass myClass= new MyClass(5,10);
            Object obj = new object();
            Console.WriteLine(myClass.ToString());
            Console.WriteLine(obj.ToString());

            //Assignment 2.Demonstrate the above class for A System.Dictionary as A key and do following operations.
            //A.Ability to add A key value
            //B.Update value by key
            //c.Delete value by using key
            Dictionary<MyClass, string> myDictionary= new Dictionary<MyClass, string>();
            
            MyClass myClass1 = new MyClass(5,10);
            MyClass myClass2 = new MyClass(5,15);

            myDictionary.Add(myClass1, "One");
            myDictionary.Add(myClass2, "Two");

            foreach (KeyValuePair<MyClass, string> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            MyClass myClass3 = new MyClass(10, 15);
            myDictionary[myClass3] = "Three";

            Console.WriteLine("Update value by key : Key = {0}, Value = {1}", myClass3 , myDictionary[myClass3]);

            Console.WriteLine("Delete value by using key");

            myDictionary.Remove(myClass2);

            foreach (KeyValuePair<MyClass, string> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            //Assignment 3.Implement the caching mechanism for clever memory management and provide below features,
            //A.Caching should take any type and can be retrieved by A string key.
            //B.It should allow clearing cache by key.
            //c.It should allow updating the existing caching by key.

            Console.ReadKey();
        }
    }
}
