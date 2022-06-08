using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opg2WineCoolerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg2WineCoolerLib.Tests
{
    [TestClass()]
    public class CoolerTests
    {
        private Cooler cooler;

        //[TestInitialize]
        //public void SetUp()
        //{
        //    Cooler cooler = new Cooler(1, 10, 3, 9);
        //}
        [TestMethod()]
        public void CoolerTest()
        {
            Cooler cooler = new Cooler(1, 10, 3, 9);

            Assert.AreEqual(1,cooler.Id);
            Assert.AreEqual(10,cooler.CapacityOfBottles);
            Assert.AreEqual(3, cooler.Temp);
            Assert.AreEqual(9,cooler.BottlesInStorage);
        }

        [TestMethod()]
        public void CoolerIsFullTest()
        {
            Cooler cooler = new Cooler(1, 10, 3, 9);
            Assert.AreEqual(false, cooler.CoolerIsFull());
            cooler.AddWine();
            Assert.AreEqual(true, cooler.CoolerIsFull());
        }

        [TestMethod()]
        public void CoolerIsFullTest2()
        {
            Cooler cooler = new Cooler(1, 10, 3, 10);
            //Assert.AreEqual(10, cooler.BottlesInStorage);
            // cooler.CoolerIsFull();
            Assert.AreEqual(true, cooler.CoolerIsFull());
        }


        [TestMethod()]
        public void AddWineTest()
        {
            Cooler cooler = new Cooler(1, 10, 3, 9);
            cooler.AddWine();
            Assert.AreEqual(10,cooler.BottlesInStorage);
        }

        [TestMethod()]
        public void AddWineTest1()//testes med exepction hvis der tilføjes en ny bottle 
        {
            Cooler cooler = new Cooler(1, 9, 3, 10);
            Assert.AreEqual(9, cooler.BottlesInStorage);
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => cooler.AddWine()));
        }
    }
}