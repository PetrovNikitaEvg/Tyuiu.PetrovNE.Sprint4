using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PetrovNE.Sprint4.Task0.V13.Lib;

namespace Tyuiu.PetrovNE.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServieTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = ds.GetSumEvenArrEl(array);
            int wait = 26;
            Assert.AreEqual(wait, res);
        }
    }
}
