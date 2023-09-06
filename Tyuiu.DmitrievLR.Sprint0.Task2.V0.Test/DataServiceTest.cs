using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint0.Task2.V0.lib;

namespace Tyuiu.DmitrievLR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Леонид";
            //запрос к библиотеке 
            var res = DataService.GetMessage(name);

            // Assert - ожидание такого же ответа
            Assert.AreEqual("Привет..., Леонид", res);
        }
    }
}
