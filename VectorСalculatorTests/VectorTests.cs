using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorСalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorСalculator.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var vector = new Vector(10, 23);
            Assert.AreEqual("10 23", vector.Verbose());
        }
        //сложение двух векторов


        //вычитание двух векторов


        //вычисление скалярного произведения двух векторов


        //вычисление длины вектора


        //вычисление векторного произведения двух векторов


    }
}