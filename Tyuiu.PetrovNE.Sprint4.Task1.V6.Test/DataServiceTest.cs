using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint4.Task1.V6.Lib;

namespace Tyuiu.PetrovNE.Sprint4.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] Array = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            int wait = 1024, res = ds.Calculate(Array);
            Assert.AreEqual(wait, res);
        }
    }
}
