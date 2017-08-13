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
            Employee employee1 = new Employee();
            employee1.Age = 26;
            employee1.Name = "XYZ";

            SimpleCache simpleCache = new SimpleCache();

            simpleCache.Add("one",employee1);

            Assert.IsNotNull(simpleCache);

            Debug.WriteLine("Key = {0}, Value = {1}", "one", simpleCache.Retrive("one").GetType());
        }

        [TestMethod]
        public void ClearTest()
        {
            Employee employee1 = new Employee();
            employee1.Age = 26;
            employee1.Name = "XYZ";

            SimpleCache simpleCache = new SimpleCache();
            simpleCache.Add("one", employee1);

            simpleCache.Clear("one");

            Assert.IsNotNull(simpleCache);

            Debug.WriteLine("Key = {0}, Value = {1}", "one", simpleCache.Retrive("one"));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Employee employee1 = new Employee();
            employee1.Age = 26;
            employee1.Name = "XYZ";

            SimpleCache simpleCache = new SimpleCache();
            simpleCache.Add("one", employee1);
            var emp = (Employee)simpleCache.Retrive("one");
            Assert.IsNotNull(simpleCache);
            Debug.WriteLine("Key = {0}, Employee Value Name = {1} Age = {2}", "one", emp.Name, emp.Age);

            employee1.Name = "PQR";
            simpleCache.Update("one", employee1);
            emp = (Employee)simpleCache.Retrive("one");
            Assert.IsNotNull(simpleCache);
            Debug.WriteLine("Key = {0}, Employee Value Name = {1} Age = {2}", "one", emp.Name, emp.Age);
        }

        [TestMethod]
        public void RetriveTest()
        {
            Employee employee1 = new Employee();
            employee1.Age = 26;
            employee1.Name = "XYZ";

            SimpleCache simpleCache = new SimpleCache();
            simpleCache.Add("one", employee1);

            var value = (Employee)simpleCache.Retrive("one");
            Assert.IsNotNull(simpleCache);
            Debug.WriteLine("Employee Name = {0}, Age = {1}", value.Name, value.Age);
        }
    }
}
