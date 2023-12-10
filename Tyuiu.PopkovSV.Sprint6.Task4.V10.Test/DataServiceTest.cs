using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PopkovSV.Sprint6.Task4.V10.Lib;

namespace Tyuiu.PopkovSV.Sprint6.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] WaitArray;
            WaitArray = new double[len];

            WaitArray[0] = -15.40;
            WaitArray[1] = -13.31;
            WaitArray[2] = -11.36;
            WaitArray[3] = -8.00;
            WaitArray[4] = -2.62;
            WaitArray[5] = 1.83;
            WaitArray[6] = 4.49;
            WaitArray[7] = 6.78;
            WaitArray[8] = 10.58;
            WaitArray[9] = 17.38;
            WaitArray[10] = 23.76;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(WaitArray, res);

        }
    }
}