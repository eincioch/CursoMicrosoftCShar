using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp02_Estructura
{
    /// <summary>
    /// Estructura
    /// </summary>
    struct BilingDetails
    {

        private string name;
        public string fieldPublic;

        //forma explicita de usar las fucnaiones de acceso
        public string Name { get { return name; } set { name = value; } }

        //propfull
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        //prop + tab
        public string AccountNumber { get; set; }

        //propg
        //public int MyProperty { get; private set; }

        //ctor
        public BilingDetails(string name, string fieldPublic, string accountNumber)
        {
            this.name = name;
            this.fieldPublic = fieldPublic;
            AccountNumber = accountNumber;
        }

    }
}
