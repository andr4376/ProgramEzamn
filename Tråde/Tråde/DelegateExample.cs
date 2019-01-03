using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tråde
{
    class DelegateExample
    {
        //Metoder som bruger NumberExaminer Delegat'en, skal have samme returtype og parametre
        //Delegates tillader at du kan parametize kode / metoder
        public delegate bool NumberExaminerDelegate(int number);


        public static bool LessThanTen(int number)
        {
            if (number < 10)
            {
                Console.WriteLine("number is less than 10");

                return true;
            }
            return false;
        }
        public static bool GreaterThanTen(int number)
        {
            if (number > 10)
            {
                Console.WriteLine("number is greater than 10");

                return true;
            }
            return false;
        }


        public static void ExamineNumber(int number, NumberExaminerDelegate examiner)
        {
            if (examiner(number))
            {
                Console.WriteLine("Used "+examiner+" to access code");
            }
        }
    }
}
