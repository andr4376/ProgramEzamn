using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    /// <summary>
    /// Delaying the initialization of objects untill necessary
    /// if not done using the c# functionality "Lazy", simply put "initialize" method in property
    /// </summary>
    class LazyLoading
    {
        private Lazy<List<int>> field = null; // the field that needs to be "lazy loaded"

        public List<int> Property //property to access the field
        {
            get
            {
                return field.Value; // access value bc it's using the c# lazy funtionality
            }
        }

        public LazyLoading()
        {
            field = new Lazy<List<int>>(() => InitializeField()); //when field is accessed run this method
            //similar to subsribing to events
        }


        List<int> InitializeField()
        {
            List<int> tmp = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                tmp.Add(i);
            }

            return tmp;
        }

        public override string ToString()
        {
            string tmp = string.Empty;

            foreach (int num in Property /*accessing the field */)
            {
                tmp = tmp + num;
            }

            return tmp;
        }
    }
}
