using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticasAmazon;
using System.Net;

namespace UnitTestAmazon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void prueba1()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 54;
            packageWeights.Add(4);
            packageWeights.Add(20);
            packageWeights.Add(13);
            packageWeights.Add(8);
            packageWeights.Add(9);

            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta= p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba2()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 21;
            packageWeights.Add(2);
            packageWeights.Add(9);
            packageWeights.Add(10);
            packageWeights.Add(3);
            packageWeights.Add(7);

            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba3()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 37;
            packageWeights.Add(7);
            packageWeights.Add(10);
            packageWeights.Add(20);
            packageWeights.Add(4);
            packageWeights.Add(3);
            packageWeights.Add(10);

            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba4()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 64;
            packageWeights.Add(20);
            packageWeights.Add(5);
            packageWeights.Add(9);
            packageWeights.Add(30);
            packageWeights.Add(10);
            packageWeights.Add(2);
            packageWeights.Add(3);
            packageWeights.Add(1);

            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba5()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 98;
            packageWeights.Add(30);
            packageWeights.Add(10);
            packageWeights.Add(5);
            packageWeights.Add(20);
            packageWeights.Add(33);
            packageWeights.Add(2);
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba6()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 72;
            packageWeights.Add(30);
            packageWeights.Add(2);
            packageWeights.Add(10);
            packageWeights.Add(30);
            packageWeights.Add(2);
            packageWeights.Add(1);
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba7()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 72;
            packageWeights.Add(30);
            packageWeights.Add(2);
            packageWeights.Add(10);
            packageWeights.Add(30);
            packageWeights.Add(2);
            packageWeights.Add(1);
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba8()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 30;
            packageWeights.Add(30);
            packageWeights.Add(1);
            packageWeights.Add(2);
            packageWeights.Add(5);
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba9()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 100;
            packageWeights.Add(100);
            packageWeights.Add(5);
            packageWeights.Add(2);
            packageWeights.Add(3);
            packageWeights.Add(1);
            packageWeights.Add(4);
            packageWeights.Add(10);
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba10()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 30;
            packageWeights.Add(30);
            packageWeights.Add(30);
            packageWeights.Add(30);
            packageWeights.Add(10);
            packageWeights.Add(4);
            packageWeights.Add(16);
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba11()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 183;
            packageWeights.Add(90);
            packageWeights.Add(10);
            packageWeights.Add(15);
            packageWeights.Add(15);
            packageWeights.Add(20);
            packageWeights.Add(33);
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
        [TestMethod]
        public void prueba12()
        {
            List<int> packageWeights = new List<int>();
            int respuesta = 0;
            int esperado = 64;
            packageWeights.Add(10);
            packageWeights.Add(5);
            packageWeights.Add(2);
            packageWeights.Add(9);
            packageWeights.Add(3);
            packageWeights.Add(4);
            packageWeights.Add(11);
            packageWeights.Add(20);
            packageWeights.Add(5);
            packageWeights.Add(3);
            packageWeights.Add(2);
            
            PracticasAmazon.Program p = new PracticasAmazon.Program();
            respuesta = p.ExamenAmazon2(packageWeights);
            Assert.AreEqual(respuesta, esperado);
        }
    }
}
