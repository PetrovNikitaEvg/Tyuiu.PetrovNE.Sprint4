using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint4.Task5.V17.Lib;

namespace Tyuiu.PetrovNE.Sprint4.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] Array = new int[5, 5] { { -1, 2, 4, 4, 4 }, { -2, 6, 6, 3, 2 },
                { -3, 2, 5, -4, 3 }, { 5, 5, 6, 4, 3 }, { -5, 6, 5, 6, -6 } };

            int wait = 6;
            int res = ds.Calculate(Array);

            Assert.AreEqual(wait, res);
        }
    }
}
