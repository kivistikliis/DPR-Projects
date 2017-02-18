using System;
using Week2ObserverPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAttachedObserverList()
        {
            Stock thestock = new Stock();
            Observer first = new Observer(thestock);
            Observer second = new Observer(thestock);

            //check the number of attached observers with any changes

            Assert.AreEqual(0, thestock.GetNrOfAttachedObservers());

            thestock.Attach(first);
            Assert.AreEqual(1, thestock.GetNrOfAttachedObservers());

            thestock.Attach(second);
            Assert.AreEqual(2, thestock.GetNrOfAttachedObservers());

            thestock.Detach(first);
            Assert.AreEqual(1, thestock.GetNrOfAttachedObservers());

            thestock.Detach(second);
            Assert.AreEqual(0, thestock.GetNrOfAttachedObservers());
        }

        [TestMethod]
        public void TestNotifyingObservers()
        {
            Stock thestock = new Stock();
            Observer first = new Observer(thestock);
            Observer second = new Observer(thestock);

            thestock.Attach(first);

            Assert.AreEqual(12, thestock.GetValue());

            //value should be same for all observers
            Assert.AreEqual(12, first.newvalue);
            Assert.AreEqual(12, second.newvalue);

            //value should change only for attach observer 'first'
            thestock.ChangeValue(15);
            Assert.AreEqual(15, first.newvalue);
            Assert.AreEqual(12, second.newvalue);

            //'first' deataches so value wont be changed for any observer, none is attached anymore
            thestock.Detach(first);
            thestock.ChangeValue(4);
            Assert.AreEqual(15, first.newvalue);
            Assert.AreEqual(12, second.newvalue);
        }

        [TestMethod]
        public void TestChangeValue()
        {
            Stock thestock = new Stock();

            Assert.AreEqual(12, thestock.GetValue());

            thestock.ChangeValue(5);
            Assert.AreEqual(5, thestock.GetValue());
        }
    }
}
