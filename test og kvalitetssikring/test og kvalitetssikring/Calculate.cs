using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_og_kvalitetssikring
{
    public class Calculate
    {

        private List<double> results = new List<double>();

        private double threeNums;


        public int[] arrayWithMax3Values = new int[3];

        public double ThreeNums
        {
            get { return threeNums; }
            set { threeNums = value; }
        }


        public List<double> Results
        {
            get { return results; }
        }

        public void StoreResult(double value)
        {
            results.Add(value);
        }

        public void SortResult(bool ascending) //condition coverage, afprøv både sandt of falsk
        {

            /*TEST ALLE IF STATEMENTS OG "PATHS" I KODEN*/
            //Branch Coverage


            if (results.Count <= 1)
            {
                //test denne
                throw new EmptyNumberListException("Not enough elements in list to sort ");
            }
            if (ascending)
            {
                results.Sort();
                //test denne

            }
            else
            {
                results.Sort();
                results.Reverse();
                //test denne

            }
        }





        public double Plus(double a, double b)
        {
            return a + b;
        }
        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Roundup(double a)
        {
            return Math.Ceiling(a);
        }
        public double RoundDown(double a)
        {
            return Math.Floor(a);
        }

        public double RoundToNearest(double val)
        {
            return Math.Round(val);
        }

        public double SquareRoot(double val)
        {
            if (val > 0)
            {
                return Math.Sqrt(val);
            }
            else
            {
                throw new NegativeSquareRoot("Cannot do squareroot of negative number");

            }

        }

        public bool IsEven(double a)
        {
            return a % 2 == 0;
        }

        public bool IsPositive(double a)
        {
            return a > 0 ? true : false;
        }
        public bool IsNegative(double a)
        {
            return a < 0 ? true : false;
        }

        public void AddThreeNums(double a, double b, double c)
        {
            double result = a + b + c;

            threeNums = result;
        }


    }

    public class EmptyNumberListException : Exception
    {
        public EmptyNumberListException(string mess) : base(mess)
        {

        }
    }

    public class NegativeSquareRoot : Exception
    {
        public NegativeSquareRoot(string mess) : base(mess)
        {

        }
    }
}
