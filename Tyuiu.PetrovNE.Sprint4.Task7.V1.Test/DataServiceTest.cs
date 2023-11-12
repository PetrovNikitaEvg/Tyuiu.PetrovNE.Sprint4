using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PetrovNE.Sprint4.Task7.V1.Lib;

namespace Tyuiu.PetrovNE.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string str = "135792468";
            int rows = 3, columns = 3, res = ds.Calculate(rows, columns, str), wait = 4;
            int[,] mtrx = new int[rows, columns];
            Assert.AreEqual(res, wait);
        }
    }
}
