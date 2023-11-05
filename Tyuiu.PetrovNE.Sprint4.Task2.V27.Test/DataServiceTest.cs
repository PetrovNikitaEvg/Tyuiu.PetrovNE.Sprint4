using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Tyuiu.PetrovNE.Sprint4.Task2.V27.Lib;

namespace Tyuiu.PetrovNE.Sprint4.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] Array = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            int wait = 20, res = ds.Calculate(Array);
            Assert.AreEqual(wait, res);
        }
    }
}
