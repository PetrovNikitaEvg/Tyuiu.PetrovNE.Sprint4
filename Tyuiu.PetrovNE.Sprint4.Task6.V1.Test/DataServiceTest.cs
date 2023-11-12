using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint4.Task6.V1.Lib;

namespace Tyuiu.PetrovNE.Sprint4.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var Array = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(Array), wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
