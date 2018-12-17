using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_og_kvalitetssikring
{
    class FakeClass
    {
        public enum Options { Do, DoNot, Neither }

        bool Do = false;
        bool DoNot = false;
        int doNotValue = 5;

        bool isHappy = true;

        public void DoThis()
        {

        }

        public void DoThat()
        {

        }

        public void DoSomething(bool shouldDo, int number)
        {
            if (shouldDo) //Test True & false
            {
                //Do this

                if (number > 5) //Test higher and lower than 5
                {
                    //Do that
                }
            }
        }

        public void DoSomethingElse()
        {

        }

        public byte ConvertIntToByte(int number)
        { 
            //                 255                         0
            if (number <= byte.MaxValue && number >= byte.MinValue)
            {
               return Convert.ToByte(number);
            }
            else
            {
                throw new OverflowException("Invalid number");
            }

        }



    }
    public class NotHappyException : Exception
    {

    }
}
