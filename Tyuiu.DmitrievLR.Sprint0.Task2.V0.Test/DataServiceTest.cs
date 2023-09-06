using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Леонид";
            // вызов функции
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Леонид", res);
        }
    }
}
