using UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject3
{
    
    
    /// <summary>
    ///Это класс теста для BoxTest, в котором должны
    ///находиться все модульные тесты BoxTest
    ///</summary>
    [TestClass()]
    public class CylinderTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для GetVolume
        ///</summary>
        [TestMethod()]
        public void GetVolumeTest()
        {
            double heigth = 2F; // TODO: инициализация подходящего значения
            double radius = 2F; // TODO: инициализация подходящего значения
            Cylinder target = new Cylinder(heigth, radius); // TODO: инициализация подходящего значения
            double expected = 25.1327413281006F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.GetVolume();
            Assert.IsTrue(Math.Abs(actual - expected)<0.000001);
           
        }
    }
}
