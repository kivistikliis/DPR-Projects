using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week6IteratorPattern;

namespace UnitTextIterator
{
    [TestClass]
    public class UnitTest
    {
        private Class ei4s1,ei4s2;
        private Students students;
        private Iterator it;

        [TestInitialize]
        public void TestSetup()
        {
            //This is a setup for all the tests, they might need the following operation to perform

            students = new Students();
            ei4s1 = new EI4S1();
            ei4s2 = new EI4S2();    
        }

        [TestMethod]
        public void createClass()
        {
            //A test that check the creation of a class, the exact type of a class and the instance of it
            Assert.AreEqual(ei4s1.GetType(), typeof(EI4S1));
            Assert.AreEqual(ei4s2.GetType(), typeof(EI4S2));

            Assert.IsInstanceOfType(ei4s1, typeof(Class));
            Assert.IsInstanceOfType(ei4s2, typeof(Class));
        }

        [TestMethod]
        public void createIterator()
        {
            //This test check the exact type of the iterators and if they are also an instance of the Iterator instance
            Assert.AreEqual(ei4s1.createIterator().GetType(), typeof(EI4S1Iterator));
            Assert.AreEqual(ei4s2.createIterator().GetType(), typeof(EI4S2Iterator));

            Assert.IsInstanceOfType(ei4s1.createIterator(), typeof(Iterator));
            Assert.IsInstanceOfType(ei4s2.createIterator(), typeof(Iterator));
        }
        [TestMethod]
        public void iterateEI4S1()
        {
            //Checking if the elements in the aggregation are right
            students.createEI4S1();

             it= students.createEI4S1Iterator();

            Student student = (Student)it.next();
            Assert.AreEqual("Dimitar",student.getFirstName());
            Assert.AreEqual("2 year", student.getYear());

            student = (Student)it.next();
            Assert.AreEqual("Dmitrii", student.getFirstName());
            Assert.AreEqual("2 year", student.getYear());
        }

        [TestMethod]
        public void iterateEI4S2()
        {
            //Checking if the elements in the aggregation are right
            students.createEI4S2();

            it = students.createEI4S2Iterator();

            Student student = (Student)it.next();
            Assert.AreEqual("Alexandru", student.getFirstName());
            Assert.AreEqual("2 year", student.getYear());

            student = (Student)it.next();
            Assert.AreEqual("Liis", student.getFirstName());
            Assert.AreEqual("2 year", student.getYear());
        }

    }
}
