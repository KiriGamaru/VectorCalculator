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
            Assert.AreEqual("10 ; 23", vector.Verbose());
        }
        //сложение двух векторов
        [TestMethod()]
        public void AdditionTest()
        {
            var a = new Vector(0, 6);
            var b = new Vector(4, 13);
            var c = Vector.Addition(a, b);
            Assert.AreEqual("4 ; 19", c.Verbose());
        }

        //вычитание двух векторов
        [TestMethod()]
        public void SubtractionTest()
        {
            var a = new Vector(32, 8);
            var b = new Vector(17, 9);
            var c = Vector.Subtraction(a, b);
            Assert.AreEqual("15 ; -1", c.Verbose());
        }

        //вычисление скалярного произведения двух векторов
        [TestMethod()]
        public void SkalTest()
        {
            var a = new Vector(12, 5);
            var b = new Vector(7, 10);
            Assert.AreEqual(134, Vector.Skal(a,b));
        }

        //вычисление длины вектора
        [TestMethod()]
        public void LengthTest()
        { 
            var a = new Vector(-3, 4);
            Assert.AreEqual(5, Vector.Length(a));
        }

        //вычисление векторного произведения двух векторов
        [TestMethod()]
        public void CrossProductTest()
        {
            var a = new Vector(11, 7);
            var b = new Vector(5, 3);
            Assert.AreEqual(2, Vector.CrossProduct(a, b));
        }

    }
}