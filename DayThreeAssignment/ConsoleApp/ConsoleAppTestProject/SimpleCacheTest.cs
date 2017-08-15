using System;
using System.Collections.Generic;
using System.Diagnostics;
using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppTestProject
{
    [TestClass]
    public class SimpleCacheTest
    {
        [TestMethod]
        public void AddTest()
        {
            Employee employee1 = new Employee
            {
                Age = 26,
                Name = "XYZ"
            };

            SimpleCache simpleCache = new SimpleCache();

            simpleCache.Add("one",employee1);

            Assert.IsNotNull(simpleCache);
            Assert.AreEqual(employee1, (Employee)simpleCache.Retrive("one"));
            Debug.WriteLine("Key = {0}, Value = {1}", "one", simpleCache.Retrive("one").GetType());
            simpleCache.Clear("one");
        }

        [TestMethod]
        public void UpdateTest()
        {
            Employee employee1 = new Employee
            {
                Age = 26,
                Name = "XYZ"
            };

            SimpleCache simpleCache = new SimpleCache();
            simpleCache.Add("one", employee1);
            var emp = (Employee)simpleCache.Retrive("one");
            Assert.IsNotNull(simpleCache);
            Debug.WriteLine("Key = {0}, Employee Value Name = {1} Age = {2}", "one", emp.Name, emp.Age);
            Assert.AreEqual(26, emp.Age);
            Assert.AreEqual("XYZ", emp.Name);

            employee1.Name = "PQR";
            simpleCache.Update("one", employee1);
            emp = (Employee)simpleCache.Retrive("one");
            Assert.IsNotNull(simpleCache);
            Debug.WriteLine("Key = {0}, Employee Value Name = {1} Age = {2}", "one", emp.Name, emp.Age);
            Assert.AreEqual(26, emp.Age);
            Assert.AreEqual("PQR", emp.Name);
            simpleCache.Clear("one");
        }

        [TestMethod]
        public void RetriveTest()
        {
            Employee employee1 = new Employee
            {
                Age = 26,
                Name = "XYZ"
            };

            SimpleCache simpleCache = new SimpleCache();
            simpleCache.Add("one", employee1);

            var emp = (Employee)simpleCache.Retrive("one");
            Assert.IsNotNull(simpleCache);
            Debug.WriteLine("Employee Name = {0}, Age = {1}", emp.Name, emp.Age);
            Assert.AreEqual(26, emp.Age);
            Assert.AreEqual("XYZ", emp.Name);
            simpleCache.Clear("one");
        }

        [TestMethod]
        public void ClearTest()
        {
            Employee employee1 = new Employee
            {
                Age = 26,
                Name = "XYZ"
            };

            SimpleCache simpleCache = new SimpleCache();
            simpleCache.Add("one", employee1);

            simpleCache.Clear("one");

            Assert.IsNotNull(simpleCache);
            Debug.WriteLine("Key = {0}, Value = {1}", "one", simpleCache.Retrive("one"));
        }
    }
}
