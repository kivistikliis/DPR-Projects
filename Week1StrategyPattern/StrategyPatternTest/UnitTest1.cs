using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Week1StrategyPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1StrategyPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FillingRequests()
        {
            //Testing if filling the list works properly
            List<int> processlist = new List<int>();     

            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                processlist.Add(r.Next(0, 100));
            }
            Assert.AreEqual(processlist.Count, 15);
        }
        [TestMethod]
        public void FirstInFirstOut()
        {
            //Testing if the algorithm works good and the first element is the output
            List<int> processlist = new List<int>(new int[]{5,56,12,45,87,54,67,12,34});
            IProcessMode imode=new ModeFirstInFirstOut(processlist);
            RequestList reqlist=new ReqListCurrent(imode);

            Assert.AreEqual(5,reqlist.Process());
            processlist.RemoveAt(0);

            Assert.AreEqual(56, reqlist.Process());
            processlist.RemoveAt(0);

           Assert.AreEqual(12, reqlist.Process());
            processlist.RemoveAt(0);

        }
        [TestMethod]
        public void Scan()
        {
            //Testing if the algorithm works good and the first element is the output
            List<int> processlist = new List<int>(new int[] { 5, 56, 12, 45, 87, 54, 67, 14, 34 });
            IProcessMode imode = new ModeScan(processlist,10,true);
            RequestList reqlist = new ReqListCurrent(imode);

            Assert.AreEqual(12, reqlist.Process());  
            processlist.RemoveAt(2);

            Assert.AreEqual(14, reqlist.Process());
            processlist.RemoveAt(6);

            Assert.AreEqual(34, reqlist.Process());
            processlist.RemoveAt(6);

            Assert.AreEqual(45, reqlist.Process());
            processlist.RemoveAt(2);

        }
        [TestMethod]
        public void ShortSeekTime()
        {
            //Testing if the algorithm works good and the first element is the output
            List<int> processlist = new List<int>(new int[] { 5, 56, 12, 45, 87, 54, 67, 14, 34 });
            IProcessMode imode = new ModeShortSeekTime(processlist, 10);
            RequestList reqlist = new ReqListCurrent(imode);

            Assert.AreEqual(12, reqlist.Process());
            processlist.Remove(12);

            Assert.AreEqual(14, reqlist.Process());
            processlist.Remove(14);

            Assert.AreEqual(5, reqlist.Process());
            processlist.Remove(5);

            Assert.AreEqual(34, reqlist.Process());
            processlist.Remove(34);

        }
        [TestMethod]
        public void CScan()
        {
            //Testing if the algorithm works good and the first element is the output
            List<int> processlist = new List<int>(new int[] { 5, 56, 12, 45, 87, 54, 67, 14, 34 });
            IProcessMode imode = new ModeCScan(processlist, 25);
            RequestList reqlist = new ReqListCurrent(imode);

            Assert.AreEqual(14, reqlist.Process());
            processlist.Remove(14);

            
            Assert.AreEqual(12, reqlist.Process());
            processlist.Remove(12);

            
            Assert.AreEqual(5, reqlist.Process());
            processlist.Remove(5);

            Assert.AreEqual(4, reqlist.processmode.GetTrackBarValue(5, 100, 87, false));
            Assert.AreEqual(3, reqlist.processmode.GetTrackBarValue(4, 100, 87, false));

            Assert.AreEqual(87, reqlist.Process());     
            processlist.Remove(87);
        }
        [TestMethod]
        public void CLook()
        {
            //Testing if the algorithm works good and the first element is the output
            List<int> processlist = new List<int>(new int[] { 5, 56, 12, 45, 87, 54, 67, 14, 34 });
            IProcessMode imode = new ModeCLook(processlist, 30);
            RequestList reqlist = new ReqListCurrent(imode);


            
            Assert.AreEqual(14, reqlist.Process());
            processlist.Remove(14);

            Assert.AreEqual(12, reqlist.Process());
            processlist.Remove(12);

            Assert.AreEqual(5, reqlist.Process());
            processlist.Remove(5);

            Assert.AreEqual(4, reqlist.processmode.GetTrackBarValue(5,100,87,false));

            Assert.AreEqual(87, reqlist.Process());

            Assert.AreEqual(87, reqlist.processmode.GetTrackBarValue(5, 100, 87, false));
            processlist.Remove(87);

        }
    }
}
