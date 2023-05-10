using NUnit.Framework;
using Kalkulator;
using System;

namespace Kalkulator.Test
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void TestTambah()
        {
            double[] angka = { 2, 3, 5 };
            int[] operatorInput = { 1, 1 };
            double hasil = Program.HitungHasil(angka, operatorInput);
            Assert.AreEqual(10, hasil);
        }

        [Test]
        public void TestKurang()
        {
            double[] angka = { 5, 3 };
            int[] operatorInput = { 2 };
            double hasil = Program.HitungHasil(angka, operatorInput);
            Assert.AreEqual(2, hasil);
        }

        [Test]
        public void TestKali()
        {
            double[] angka = { 2, 3, 5 };
            int[] operatorInput = { 3, 3 };
            double hasil = Program.HitungHasil(angka, operatorInput);
            Assert.AreEqual(30, hasil);
        }

        [Test]
        public void TestBagi()
        {
            double[] angka = { 10, 2 };
            int[] operatorInput = { 4 };
            double hasil = Program.HitungHasil(angka, operatorInput);
            Assert.AreEqual(5, hasil);
        }

        
    }


}
