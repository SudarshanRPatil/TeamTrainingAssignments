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

            MyDictionary<int, string> myClass= new MyDictionary<int, string>();
            Object obj = new object();
            Console.WriteLine(myClass.ToString());
            Console.WriteLine(obj.ToString());

            //Assignment 2.Demonstrate the above class for a System.Dictionary as a key and do following operations.
            //a.Ability to add a key value
            //b.Update value by key
            //c.Delete value by using key
            myClass.Add(1,"One");
            myClass.Add(2,"Two");
            myClass.Add(3,"Three");
            myClass.Add(4,"Four");




            //Assignment 3.Implement the caching mechanism for clever memory management and provide below features,
            //a.Caching should take any type and can be retrieved by a string key.
            //b.It should allow clearing cache by key.
            //c.It should allow updating the existing caching by key.

            Console.ReadKey();
        }
    }

    public class MyDictionary<TKey, TValue> 
    {


        public override string ToString()
        {
            return "Override the Object's ToString() for MyClass";
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Update(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }
    }

}
