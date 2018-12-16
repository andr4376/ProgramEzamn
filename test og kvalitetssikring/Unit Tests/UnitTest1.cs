using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_og_kvalitetssikring;
using System.Collections;
using System.Collections.Generic;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {

        //Husk:
        //Test Grænseværdier:
        //Test med 0, positive tal, negative tal, maksværdi og min. værdi.
        //Test Null hvor det er muligt - instanser af objecter


        /*
        fyldstgørende tests: 
        lav så meget code coverage som muligt
         Code coverage:

            Method/function Coverage:
            tjekker om alle metoder i klassen er kaldt og testet igennem
            tjekker ikke om man har dækket alle paths

            statement coverage:
            Tjekker om hver eneste statement (hver ting der gør noget;) er blevet kaldt

            Branch Coverage:
            Tjekker om alle code paths / branches er blevet kørt og afprøvet.
            hvis man laver en switch case, skal alle  muligheder testes

            Conditon Coverage:
            tjekker om hver eneste bool expression skal afprøves som true & false
        
           

            Ækvivalensklasser og grænseværdier:

            Ækvivalensklasser bruges til at opdele inputværdier i et antal klasser, som skal kunne teste de vigtigste
            inputværdier for en test
            opdelingen skal være lige gode til at afsløre fejl i programmet
            man opdeler dem, for ikke at skulle lave tests på hvert eneste mulig tal

            hvis man f.eks skal have et brugernavn som må være imellem 1-25 tegn, kan man opdele inputs i ækvivelensklasser således:

            hvis inputtypen er et interval imellem a og b:

            test min: 1 tegn
            test min-1: 0 tegn 
            test min +1: 2 tegn

            test max 25 tegn
            test max-1 24 tegn
            test max+1 26 tegn

            lav test på hver enkelt

            hvis inputtypen er en værdi mængde.:
            prøv et tal i mængden 
            prøv tal under og over mængden
                                 
             */


        #region Test grænseværdier:
        [TestMethod]
        public void ResultsCanStorePositives() //positive 
        {
            Calculate calc = new Calculate();

            calc.StoreResult(5);

            List<double> expectedList = new List<double>() { 5 };

            List<double> actualList = calc.Results;

            //Assert.AreEqual sammenligner objekter, ikke deres indhold

            CollectionAssert.AreEqual(expectedList, actualList);


        }
        [TestMethod]
        public void ResultsCanStoreNegatives() //negative
        {
            Calculate calc = new Calculate();

            calc.StoreResult(-5);

            List<double> expectedList = new List<double>() { -5 };

            List<double> actualList = calc.Results;


            CollectionAssert.AreEqual(expectedList, actualList);


        }
        [TestMethod]
        public void ResultsCanStore0() //null
        {
            Calculate calc = new Calculate();

            calc.StoreResult(0);

            List<double> expectedList = new List<double>() { 0 };

            List<double> actualList = calc.Results;


            CollectionAssert.AreEqual(expectedList, actualList);


        }
        [TestMethod]
        public void ResultsCanStoreMaxVal() //max
        {
            Calculate calc = new Calculate();

            calc.StoreResult(double.MaxValue);

            List<double> expectedList = new List<double>() { double.MaxValue };

            List<double> actualList = calc.Results;


            CollectionAssert.AreEqual(expectedList, actualList);


        }
        [TestMethod]
        public void ResultsCanStoreMinVal() //min
        {
            Calculate calc = new Calculate();

            calc.StoreResult(double.MinValue);

            List<double> expectedList = new List<double>() { double.MinValue };

            List<double> actualList = calc.Results;


            CollectionAssert.AreEqual(expectedList, actualList);


        }
        #endregion

        #region ExpectingExceptions:
        [TestMethod]
        [ExpectedException(typeof(EmptyNumberListException))] //Testen bliver godkendt hvis denne exception kastes
        public void SortingExceptionWithTooFewElements()
        {
            Calculate cal = new Calculate();

            cal.StoreResult(5);


            cal.SortResult(true);


        }

        [TestMethod]
        [ExpectedException(typeof(NegativeSquareRoot))]
        public void SqrtNegative()
        {
            Calculate cal = new Calculate();

            double actual = cal.SquareRoot(-9);


        }
        #endregion;

        #region Comparing Collections
        [TestMethod]
        public void SortByAscending()
        {
            Calculate cal = new Calculate();

            cal.StoreResult(5);
            cal.StoreResult(3);
            cal.StoreResult(2);
            cal.StoreResult(6);
            cal.StoreResult(1);

            cal.SortResult(true);

            List<double> expectedList = new List<double>() { 1, 2, 3, 5, 6 };

            List<double> actual = cal.Results;

            CollectionAssert.AreEqual(actual, expectedList);

        }
        [TestMethod]
        public void SortByDescending()
        {
            Calculate cal = new Calculate();

            cal.StoreResult(5);
            cal.StoreResult(3);
            cal.StoreResult(2);
            cal.StoreResult(6);
            cal.StoreResult(1);

            cal.SortResult(false);

            List<double> expectedList = new List<double>() { 6, 5, 3, 2, 1 };

            List<double> actual = cal.Results;

            CollectionAssert.AreEqual(actual, expectedList);

        }
        #endregion



        [TestMethod]
        public void IsResultListNotNull()
        {
            Calculate calc = new Calculate();


            Assert.IsNotNull(calc.Results);
        }

        [TestMethod]
        public void TestVoidMethod()
        {
            Calculate calc = new Calculate();

            calc.AddThreeNums(1, 2, 3);

            double result = calc.ThreeNums;

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void RoundUpPositive()
        {
            Calculate cal = new Calculate();

            double actual = cal.Roundup(5.4);

            double expected = 6;


            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void RoundDownPositive()
        {
            Calculate cal = new Calculate();

            double actual = cal.RoundDown(5.4);

            double expected = 5;


            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void RoundToNearestAboveHalf()
        {
            Calculate cal = new Calculate();

            double actual = cal.RoundToNearest(5.6);

            double expected = 6;


            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void RoundToNearestBelowHalf()
        {
            Calculate cal = new Calculate();

            double actual = cal.RoundToNearest(5.4);

            double expected = 5;


            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void RoundToNearestMiddle()
        {
            Calculate cal = new Calculate();

            double actual = cal.RoundToNearest(5.5);

            double expected = 6;


            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void SqrtPositive()
        {
            Calculate cal = new Calculate();

            double actual = cal.SquareRoot(9);

            double expected = 3;


            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void AddPositiveNumbers()
        {
            Calculate cal = new Calculate();

            double actual = cal.Plus(15, 5);

            double expected = 20;


            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void AddNegativeNumbers()
        {
            Calculate cal = new Calculate();

            double actual = cal.Minus(15, 5);

            double expected = 10;


            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideBy0()
        {
            Calculate cal = new Calculate();

            cal.Divide(3, 0);

        }

        [TestMethod]
        public void MultiPlyNegatives()
        {
            Calculate cal = new Calculate();

            double actual = cal.Multiply(-5, -2);

            double expected = 10;


            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddOutOfIndexInArray()
        {
            Calculate cal = new Calculate();

            cal.arrayWithMax3Values[0] = 1;
            cal.arrayWithMax3Values[1] = 2;
            cal.arrayWithMax3Values[2] = 3;
            cal.arrayWithMax3Values[3] = 4; // out of range

        }





    }
}
